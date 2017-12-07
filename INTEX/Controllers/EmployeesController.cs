using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace INTEX.Models
{
    public class EmployeesController : Controller
    {
        private northwestContext db = new northwestContext();

        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Authorization).Include(e => e.EmployeeType).Include(e => e.Location).Include(e => e.User);
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.AuthID = new SelectList(db.Authorizations, "AuthID", "AuthName");
            ViewBag.EmpTypeID = new SelectList(db.EmployeeTypes, "EmpTypeID", "EmpTypeDesc");
            ViewBag.LocID = new SelectList(db.Locations, "LocID", "City");
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Password");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpID,EmpFirstName,EmpLastName,EmpDOB,EmpSSN,EmpPhone,EmpEmail,EmpStreetAddress1,EmpStreetAddress2,LocID,AuthID,Wage,UserID,EmpTypeID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthID = new SelectList(db.Authorizations, "AuthID", "AuthName", employee.AuthID);
            ViewBag.EmpTypeID = new SelectList(db.EmployeeTypes, "EmpTypeID", "EmpTypeDesc", employee.EmpTypeID);
            ViewBag.LocID = new SelectList(db.Locations, "LocID", "City", employee.LocID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Password", employee.UserID);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthID = new SelectList(db.Authorizations, "AuthID", "AuthName", employee.AuthID);
            ViewBag.EmpTypeID = new SelectList(db.EmployeeTypes, "EmpTypeID", "EmpTypeDesc", employee.EmpTypeID);
            ViewBag.LocID = new SelectList(db.Locations, "LocID", "City", employee.LocID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Password", employee.UserID);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpID,EmpFirstName,EmpLastName,EmpDOB,EmpSSN,EmpPhone,EmpEmail,EmpStreetAddress1,EmpStreetAddress2,LocID,AuthID,Wage,UserID,EmpTypeID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthID = new SelectList(db.Authorizations, "AuthID", "AuthName", employee.AuthID);
            ViewBag.EmpTypeID = new SelectList(db.EmployeeTypes, "EmpTypeID", "EmpTypeDesc", employee.EmpTypeID);
            ViewBag.LocID = new SelectList(db.Locations, "LocID", "City", employee.LocID);
            ViewBag.UserID = new SelectList(db.Users, "UserID", "Password", employee.UserID);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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
