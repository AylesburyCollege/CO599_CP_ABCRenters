using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CO599_CP_ABCRenters.Models;

namespace CO599_CP_ABCRenters.Controllers
{
    public class HomeController : Controller
    {
        private PropertyDbContext db = new PropertyDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Properties()
        {
            return View(db.Properties.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Property property = db.Properties.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        public ActionResult RequestViewing()
        {
            return View();
        }
    }
}