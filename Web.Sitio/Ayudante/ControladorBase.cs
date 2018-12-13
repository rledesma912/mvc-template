using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Front.Sitio.Ayudante
{
    public class ControladorBase : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MvcApplication));

        protected override void OnException(ExceptionContext filterContext)
        {
            //No trapear error si ya estaba manejado desde global asax
            if (filterContext.ExceptionHandled)
                return;

            log.Error(filterContext.Exception);

            filterContext.ExceptionHandled = true;

            //Redirigir a una vista de errores.
            filterContext.Result = this.RedirectToAction("Error", "Error", new { message = filterContext.Exception.Message, type = filterContext.Exception.GetType(), status = filterContext.HttpContext.Response.StatusCode });

            //Eliminio contexto de la respuesta que provocó error.
            filterContext.HttpContext.Response.Clear();

            base.OnException(filterContext);
        }
    }
}