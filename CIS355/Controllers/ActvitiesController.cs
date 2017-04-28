using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIS355.Models;

namespace CIS355.Controllers
{
    [Authorize]
    public class ActvitiesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Actvities
        public ActionResult Index()
        {
            return View(db.Actvities.ToList());
        }

        // GET: Actvities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actvity actvity = db.Actvities.Find(id);
            if (actvity == null)
            {
                return HttpNotFound();
            }
            return View(actvity);
        }

        // GET: Actvities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actvities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,Points,Name,Type,NeedsVerify")] Actvity actvity)
        {
            if (ModelState.IsValid)
            {
                db.Actvities.Add(actvity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actvity);
        }

        // GET: Actvities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actvity actvity = db.Actvities.Find(id);
            if (actvity == null)
            {
                return HttpNotFound();
            }
            return View(actvity);
        }

        // POST: Actvities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,Points,Name,Type,NeedsVerify")] Actvity actvity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actvity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actvity);
        }

        // GET: Actvities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actvity actvity = db.Actvities.Find(id);
            if (actvity == null)
            {
                return HttpNotFound();
            }
            return View(actvity);
        }

        // POST: Actvities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Actvity actvity = db.Actvities.Find(id);
            db.Actvities.Remove(actvity);
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
