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
    public class AssayTestCatalogsController : Controller
    {
        private northwestContext db = new northwestContext();

        // GET: AssayTestCatalogs
        public ActionResult Index()
        {
            var assayTestCatalogs = db.AssayTestCatalogs.Include(a => a.Assay).Include(a => a.Test).Include(a => a.TestCondition);
            return View(assayTestCatalogs.ToList());
        }

        // GET: AssayTestCatalogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayTestCatalog assayTestCatalog = db.AssayTestCatalogs.Find(id);
            if (assayTestCatalog == null)
            {
                return HttpNotFound();
            }
            return View(assayTestCatalog);
        }

        // GET: AssayTestCatalogs/Create
        public ActionResult Create()
        {
            ViewBag.AssayID = new SelectList(db.Assays, "AssayID", "AssayName");
            ViewBag.TestID = new SelectList(db.Tests, "TestID", "TestName");
            ViewBag.TestConditionID = new SelectList(db.TestConditions, "TestConditionID", "TestConditionDesc");
            return View();
        }

        // POST: AssayTestCatalogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TestID,AssayID,TestConditionID")] AssayTestCatalog assayTestCatalog)
        {
            if (ModelState.IsValid)
            {
                db.AssayTestCatalogs.Add(assayTestCatalog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AssayID = new SelectList(db.Assays, "AssayID", "AssayName", assayTestCatalog.AssayID);
            ViewBag.TestID = new SelectList(db.Tests, "TestID", "TestName", assayTestCatalog.TestID);
            ViewBag.TestConditionID = new SelectList(db.TestConditions, "TestConditionID", "TestConditionDesc", assayTestCatalog.TestConditionID);
            return View(assayTestCatalog);
        }

        // GET: AssayTestCatalogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayTestCatalog assayTestCatalog = db.AssayTestCatalogs.Find(id);
            if (assayTestCatalog == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssayID = new SelectList(db.Assays, "AssayID", "AssayName", assayTestCatalog.AssayID);
            ViewBag.TestID = new SelectList(db.Tests, "TestID", "TestName", assayTestCatalog.TestID);
            ViewBag.TestConditionID = new SelectList(db.TestConditions, "TestConditionID", "TestConditionDesc", assayTestCatalog.TestConditionID);
            return View(assayTestCatalog);
        }

        // POST: AssayTestCatalogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TestID,AssayID,TestConditionID")] AssayTestCatalog assayTestCatalog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assayTestCatalog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AssayID = new SelectList(db.Assays, "AssayID", "AssayName", assayTestCatalog.AssayID);
            ViewBag.TestID = new SelectList(db.Tests, "TestID", "TestName", assayTestCatalog.TestID);
            ViewBag.TestConditionID = new SelectList(db.TestConditions, "TestConditionID", "TestConditionDesc", assayTestCatalog.TestConditionID);
            return View(assayTestCatalog);
        }

        // GET: AssayTestCatalogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssayTestCatalog assayTestCatalog = db.AssayTestCatalogs.Find(id);
            if (assayTestCatalog == null)
            {
                return HttpNotFound();
            }
            return View(assayTestCatalog);
        }

        // POST: AssayTestCatalogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssayTestCatalog assayTestCatalog = db.AssayTestCatalogs.Find(id);
            db.AssayTestCatalogs.Remove(assayTestCatalog);
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
