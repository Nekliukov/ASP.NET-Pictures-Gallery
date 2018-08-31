using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PicturesGallery.Models;

namespace PicturesGallery.Controllers
{
    public class HomeController : Controller
    {
        private PicturesStoreEntities db = new PicturesStoreEntities();

        // GET: Home
        public ActionResult Index()
        {
            var sd = db.PicturesTable.ToList();
            return View(sd);
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
