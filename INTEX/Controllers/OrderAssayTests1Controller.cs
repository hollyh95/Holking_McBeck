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
    public class OrderAssayTests1Controller : Controller
    {
        private northwestContext db = new northwestContext();

        // GET: OrderAssayTests1
        public ActionResult Index()
        {
            var orderAssayTests = db.OrderAssayTests.Include(o => o.OrderAssay).Include(o => o.Status).Include(o => o.Test).Include(o => o.TestCondition);
            return View(orderAssayTests.ToList());
        }

        // GET: OrderAssayTests1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderAssayTest orderAssayTest = db.OrderAssayTests.Find(id);
            if (orderAssayTest == null)
            {
                return HttpNotFound();
            }
            return View(orderAssayTest);
        }

        // GET: OrderAssayTests1/Create
        public ActionResult Create()
        {
            ViewBag.OrderAssayID = new SelectList(db.OrderAssays, "OrderAssayID", "OrderAssayID");
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDesc");
            ViewBag.TestID = new SelectList(db.Tests, "TestID", "TestName");
            ViewBag.TestConditionID = new SelectList(db.TestConditions, "TestConditionID", "TestConditionDesc");
            return View();
        }

        // POST: OrderAssayTests1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderAssayID,TestID,TestConditionID,TestConclusive,StatusID")] OrderAssayTest orderAssayTest)
        {
            if (ModelState.IsValid)
            {
                db.OrderAssayTests.Add(orderAssayTest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrderAssayID = new SelectList(db.OrderAssays, "OrderAssayID", "OrderAssayID", orderAssayTest.OrderAssayID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDesc", orderAssayTest.StatusID);
            ViewBag.TestID = new SelectList(db.Tests, "TestID", "TestName", orderAssayTest.TestID);
            ViewBag.TestConditionID = new SelectList(db.TestConditions, "TestConditionID", "TestConditionDesc", orderAssayTest.TestConditionID);
            return View(orderAssayTest);
        }

        // GET: OrderAssayTests1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderAssayTest orderAssayTest = db.OrderAssayTests.Find(id);
            if (orderAssayTest == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrderAssayID = new SelectList(db.OrderAssays, "OrderAssayID", "OrderAssayID", orderAssayTest.OrderAssayID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDesc", orderAssayTest.StatusID);
            ViewBag.TestID = new SelectList(db.Tests, "TestID", "TestName", orderAssayTest.TestID);
            ViewBag.TestConditionID = new SelectList(db.TestConditions, "TestConditionID", "TestConditionDesc", orderAssayTest.TestConditionID);
            return View(orderAssayTest);
        }

        // POST: OrderAssayTests1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderAssayID,TestID,TestConditionID,TestConclusive,StatusID")] OrderAssayTest orderAssayTest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderAssayTest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrderAssayID = new SelectList(db.OrderAssays, "OrderAssayID", "OrderAssayID", orderAssayTest.OrderAssayID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDesc", orderAssayTest.StatusID);
            ViewBag.TestID = new SelectList(db.Tests, "TestID", "TestName", orderAssayTest.TestID);
            ViewBag.TestConditionID = new SelectList(db.TestConditions, "TestConditionID", "TestConditionDesc", orderAssayTest.TestConditionID);
            return View(orderAssayTest);
        }

        // GET: OrderAssayTests1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderAssayTest orderAssayTest = db.OrderAssayTests.Find(id);
            if (orderAssayTest == null)
            {
                return HttpNotFound();
            }
            return View(orderAssayTest);
        }

        // POST: OrderAssayTests1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderAssayTest orderAssayTest = db.OrderAssayTests.Find(id);
            db.OrderAssayTests.Remove(orderAssayTest);
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
