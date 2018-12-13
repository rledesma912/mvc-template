using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LUPA.Sitio.Ayudante
{
    public class ControladorBase : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            //No trapear error si ya estaba manejado desde global asax
            if (filterContext.ExceptionHandled)
                return;
            filterContext.ExceptionHandled = true;

            //Redirigir a una vista de errores.
            filterContext.Result = this.RedirectToAction("FrontendError", "Error", new { message = filterContext.Exception.Message, type = filterContext.Exception.GetType(), status = filterContext.HttpContext.Response.StatusCode });

            //Eliminio contexto de la respuesta que provocó error.
            filterContext.HttpContext.Response.Clear();

            base.OnException(filterContext);
        }
    }
}