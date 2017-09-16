using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dvdCollection.DataAccessLayer;
using dvdCollection.Models;

namespace dvdCollection.Controllers
{
    public class dvdController : Controller
    {
        private DVDContext db = new DVDContext();

        // GET: dvd
        public ActionResult Index()
        {
            return View(db.dvd.ToList());
        }

        // GET: dvd/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dvd dvd = db.dvd.Find(id);
            if (dvd == null)
            {
                return HttpNotFound();
            }
            return View(dvd);
        }

        // GET: dvd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dvd/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dvdId,dvdTitle,dvdDirector,genre")] dvd dvd)
        {
            if (ModelState.IsValid)
            {
                db.dvd.Add(dvd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dvd);
        }

        // GET: dvd/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dvd dvd = db.dvd.Find(id);
            if (dvd == null)
            {
                return HttpNotFound();
            }
            return View(dvd);
        }

        // POST: dvd/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dvdId,dvdTitle,dvdDirector,genre")] dvd dvd)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dvd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dvd);
        }

        // GET: dvd/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dvd dvd = db.dvd.Find(id);
            if (dvd == null)
            {
                return HttpNotFound();
            }
            return View(dvd);
        }

        // POST: dvd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dvd dvd = db.dvd.Find(id);
            db.dvd.Remove(dvd);
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
