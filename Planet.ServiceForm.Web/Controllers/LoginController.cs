using Planet.ServiceForm.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Planet.ServiceForm.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        
        public ActionResult Login()
        {
            
            return View();
        }
        
                    
        
        public ActionResult KullaniciKayit()
        {
            return View();
        }
      
    }
}