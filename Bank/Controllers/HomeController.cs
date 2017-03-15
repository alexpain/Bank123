using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (BankEntities db = new BankEntities())
            {
                var clients = db.Client;
                string strBack = "";
                foreach (var client in clients)
                    strBack += client.fullName + " " + client.birthday.ToString("d") + "<br>";

                //    return strBack;
            }
            return View();
        }

       
    }
}