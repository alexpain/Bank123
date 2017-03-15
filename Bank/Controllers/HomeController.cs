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
            using (Bank.Models.Bank db = new Bank.Models.Bank())
            {
                var clients = db.Client;
                string strBack = "";
                foreach (var client in clients)
                    strBack += client.fullName + " " + client.birthday.ToString("d") + "\n ";            
                ViewBag.users = strBack;
            }
            return View();
        }


    }
}