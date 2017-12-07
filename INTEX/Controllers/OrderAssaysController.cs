using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INTEX.Models;

namespace INTEX.Controllers
{
    public class OrderAssaysController : Controller
    {
        private northwestContext db = new northwestContext();

        // GET: OrderAssays
        public ActionResult Index()
        {
            var orderAssays = db.OrderAssays.Include(o => o.Assay).Include(o => o.Order).Include(o => o.Status);
            return View(orderAssays.ToList());
        }

        // GET: OrderAssays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderAssay orderAssay = db.OrderAssays.Find(id);
            if (orderAssay == null)
            {
                return HttpNotFound();
            }
            return View(orderAssay);
        }

        // GET: OrderAssays/Create
        public ActionResult Create()
        {
            ViewBag.AssayID = new SelectList(db.Assays, "AssayID", "AssayName");
            ViewBag.OrderID = new SelectList(db.Orders, "OrderID", "OrderComments");
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDesc");
            return View();
        }

        // POST: OrderAssays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderAssayID,OrderID,AssayID,StartDateTime,EndDateTime,StatusID")] OrderAssay orderAssay)
        {
            if (ModelState.IsValid)
            {
                db.OrderAssays.Add(orderAssay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AssayID = new SelectList(db.Assays, "AssayID", "AssayName", orderAssay.AssayID);
            ViewBag.OrderID = new SelectList(db.Orders, "OrderID", "OrderComments", orderAssay.OrderID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDesc", orderAssay.StatusID);
            return View(orderAssay);
        }

        // GET: OrderAssays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderAssay orderAssay = db.OrderAssays.Find(id);
            if (orderAssay == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssayID = new SelectList(db.Assays, "AssayID", "AssayName", orderAssay.AssayID);
            ViewBag.OrderID = new SelectList(db.Orders, "OrderID", "OrderComments", orderAssay.OrderID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDesc", orderAssay.StatusID);
            return View(orderAssay);
        }

        // POST: OrderAssays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderAssayID,OrderID,AssayID,StartDateTime,EndDateTime,StatusID")] OrderAssay orderAssay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderAssay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AssayID = new SelectList(db.Assays, "AssayID", "AssayName", orderAssay.AssayID);
            ViewBag.OrderID = new SelectList(db.Orders, "OrderID", "OrderComments", orderAssay.OrderID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDesc", orderAssay.StatusID);
            return View(orderAssay);
        }

        // GET: OrderAssays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderAssay orderAssay = db.OrderAssays.Find(id);
            if (orderAssay == null)
            {
                return HttpNotFound();
            }
            return View(orderAssay);
        }

        // POST: OrderAssays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderAssay orderAssay = db.OrderAssays.Find(id);
            db.OrderAssays.Remove(orderAssay);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
