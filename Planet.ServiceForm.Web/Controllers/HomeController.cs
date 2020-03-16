using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Planet.ServiceForm.Web.Models;

namespace Planet.ServiceForm.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[Authorize]
        private firmabilgilerEntities db = new firmabilgilerEntities();
       [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ListEmployee = this.db.formtbls.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            
            string[] ids = formCollection["ID"].Split(new char[] { ',' });
            foreach (string id in ids)
            {
                var form = this.db.formtbls.Find(int.Parse(id));
                this.db.formtbls.Remove(form);
                this.db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        public ActionResult DataInput()
        {
            return View();
        }
        public ActionResult Tables()
        {
            //FirmaBilgi firma = new FirmaBilgi();
            
            return View();
        }
        public ActionResult VerileriGoster()
        {
            return View();
        }
        public ActionResult ServisForm()
        {
            return View();
        }
        public ActionResult FirmaKayit()
        {
            return View();
        }

  

    }
}