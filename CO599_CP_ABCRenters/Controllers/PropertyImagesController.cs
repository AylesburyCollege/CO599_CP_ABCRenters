using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CO599_CP_ABCRenters.Models;

namespace CO599_CP_ABCRenters.Controllers
{
    public class PropertyImagesController : Controller
    {
        private PropertyDbContext db = new PropertyDbContext();

        // GET: PropertyImages
        public ActionResult Index()
        {
            var propertyImages = db.PropertyImages.Include(p => p.Property);
            return View(propertyImages.ToList());
        }

        // GET: PropertyImages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyImage propertyImage = db.PropertyImages.Find(id);
            if (propertyImage == null)
            {
                return HttpNotFound();
            }
            return View(propertyImage);
        }

        // GET: PropertyImages/Create
        public ActionResult Create()
        {
            ViewBag.PropertyID = new SelectList(db.Properties, "PropertyID", "Name");
            return View();
        }

        // POST: PropertyImages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PropertyImageID,ImageURL,Description,Caption,ImageFormat,Rooms,PropertyID")] PropertyImage propertyImage)
        {
            if (ModelState.IsValid)
            {
                db.PropertyImages.Add(propertyImage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PropertyID = new SelectList(db.Properties, "PropertyID", "Name", propertyImage.PropertyID);
            return View(propertyImage);
        }

        // GET: PropertyImages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyImage propertyImage = db.PropertyImages.Find(id);
            if (propertyImage == null)
            {
                return HttpNotFound();
            }
            ViewBag.PropertyID = new SelectList(db.Properties, "PropertyID", "Name", propertyImage.PropertyID);
            return View(propertyImage);
        }

        // POST: PropertyImages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PropertyImageID,ImageURL,Description,Caption,ImageFormat,Rooms,PropertyID")] PropertyImage propertyImage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propertyImage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PropertyID = new SelectList(db.Properties, "PropertyID", "Name", propertyImage.PropertyID);
            return View(propertyImage);
        }

        // GET: PropertyImages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyImage propertyImage = db.PropertyImages.Find(id);
            if (propertyImage == null)
            {
                return HttpNotFound();
            }
            return View(propertyImage);
        }

        // POST: PropertyImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PropertyImage propertyImage = db.PropertyImages.Find(id);
            db.PropertyImages.Remove(propertyImage);
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
