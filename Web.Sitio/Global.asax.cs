using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Front.Sitio
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MvcApplication));
        
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Variables globales de contexto de aplicación
            Aplicacion.Initialize();

        }

        protected void Application_Error()
        {
            Exception exception = Server.GetLastError();
            Response.Clear();

            HttpException httpException = exception as HttpException;
            log.Error(exception);

            if (httpException != null)
            {
                //httpException.GetHttpCode()                

                // clear response on server
                Response.Clear();
                // clear error on server
                Server.ClearError();
                                
                Response.Redirect(String.Format("~/Error/{0}/?message={1}&type={2}", "FrontendError", exception.Message, exception.GetType()));
            }

        }
    }
}
