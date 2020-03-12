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
       
       //[HttpPost]
        public ActionResult Index(string mailFirma)
        {

            return View();
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

        //public bool IsValid(string mail)
        //{
        //    bool valid = false;
        //    string BaglantiAdresi = @"Server=SEVKETPC\SQLEXPRESS; Initial Catalog=firmabilgiler; Integrated Security=True";
        //    SqlConnection Baglanti = new SqlConnection(BaglantiAdresi);
        //    SqlCommand cmd = new SqlCommand("select * from  where firma_mail=@firmaMail", Baglanti);
        //    cmd.Parameters.AddWithValue("@firmaMail", mail);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    Baglanti.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    Baglanti.Close();

        //    if (dt.Rows.Count > 0)
        //    {

        //        valid = true;

        //    }
        //    else
        //    {

        //        valid = false;
        //    }

        //    return valid;

        //}

    }
}