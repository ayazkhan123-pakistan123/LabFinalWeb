using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LabFinalWeb.DAL;
using LabFinalWeb.Models;
using System.Text.RegularExpressions;

namespace LabFinalWeb.Controllers
{
    public class TyresController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Tyres
        public ActionResult Index()
        {
            return View(db.tyre.ToList());
        }

        // GET: Tyres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tyres tyres = db.tyre.Find(id);
            if (tyres == null)
            {
                return HttpNotFound();
            }
            return View(tyres);
        }

        // GET: Tyres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tyres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TyresId,Brand,Country,Size,Condition,Quantity,PurchasePrice,SellingPrice")] Tyres tyres)
        {
            if (ModelState.IsValid)
            {
                db.tyre.Add(tyres);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tyres);
        }

        // GET: Tyres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tyres tyres = db.tyre.Find(id);
            if (tyres == null)
            {
                return HttpNotFound();
            }
            return View(tyres);
        }

        // POST: Tyres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TyresId,Brand,Country,Size,Condition,Quantity,PurchasePrice,SellingPrice")] Tyres tyres)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tyres).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tyres);
        }

        // GET: Tyres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tyres tyres = db.tyre.Find(id);
            if (tyres == null)
            {
                return HttpNotFound();
            }
            return View(tyres);
        }

        // POST: Tyres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tyres tyres = db.tyre.Find(id);
            db.tyre.Remove(tyres);
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
