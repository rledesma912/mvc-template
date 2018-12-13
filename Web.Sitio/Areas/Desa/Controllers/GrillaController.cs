using Front.Sitio.Ayudante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Front.Sitio.Areas.Desa.Controllers
{
    public class GrillaController : ControladorBase
    {
        // GET: Desa/Grilla
        public ActionResult GrillaNet()
        {
            return View();
        }
    }
}