using Front.Sitio.Ayudante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Front.Sitio.Controllers
{
    public class DashboardController : ControladorBase
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenExc()
        {
            //new Exception("Error no controlado");

            return View("IndexXXX");
        }
    }


}