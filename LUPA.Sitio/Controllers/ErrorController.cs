using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LUPA.Sitio.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult FrontendError()
        {
            var mensaje = Request.QueryString["message"].ToString();
            var tipo = Request.QueryString["type"].ToString();
            Response.StatusCode = Request.QueryString["status"] ==null ? 200: int.Parse(Request.QueryString["status"].ToString());
            ViewBag.msj = mensaje;
            ViewBag.tipo = tipo;
            return View("Error");
        }
    }
}