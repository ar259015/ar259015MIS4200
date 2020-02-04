using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ar259015MIS4200.DAL;
using ar259015MIS4200.Models;

namespace ar259015MIS4200.Controllers
{
    public class PetDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: PetDetails
        public ActionResult Index()
        {
            var petDetails = db.PetDetails.Include(p => p.Pet).Include(p => p.Vet);
            return View(petDetails.ToList());
        }

        // GET: PetDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetDetails petDetails = db.PetDetails.Find(id);
            if (petDetails == null)
            {
                return HttpNotFound();
            }
            return View(petDetails);
        }

        // GET: PetDetails/Create
        public ActionResult Create()
        {
            ViewBag.petID = new SelectList(db.Pets, "petID", "firstName");
            ViewBag.vetId = new SelectList(db.Vets, "vetID", "firstName");
            return View();
        }

        // POST: PetDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "petdetailID,age,ownerfirstName,ownerlastName,petID,vetId")] PetDetails petDetails)
        {
            if (ModelState.IsValid)
            {
                db.PetDetails.Add(petDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petID = new SelectList(db.Pets, "petID", "firstName", petDetails.petID);
            ViewBag.vetId = new SelectList(db.Vets, "vetID", "firstName", petDetails.vetId);
            return View(petDetails);
        }

        // GET: PetDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetDetails petDetails = db.PetDetails.Find(id);
            if (petDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "firstName", petDetails.petID);
            ViewBag.vetId = new SelectList(db.Vets, "vetID", "firstName", petDetails.vetId);
            return View(petDetails);
        }

        // POST: PetDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "petdetailID,age,ownerfirstName,ownerlastName,petID,vetId")] PetDetails petDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petID = new SelectList(db.Pets, "petID", "firstName", petDetails.petID);
            ViewBag.vetId = new SelectList(db.Vets, "vetID", "firstName", petDetails.vetId);
            return View(petDetails);
        }

        // GET: PetDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetDetails petDetails = db.PetDetails.Find(id);
            if (petDetails == null)
            {
                return HttpNotFound();
            }
            return View(petDetails);
        }

        // POST: PetDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PetDetails petDetails = db.PetDetails.Find(id);
            db.PetDetails.Remove(petDetails);
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
