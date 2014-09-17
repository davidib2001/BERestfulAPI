using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;



using System.Web.Http.Controllers;
using System.Web.Http.Description;
using System.Collections.ObjectModel;
using OpenAPI3.Areas.HelpPage.Models;

namespace OpenAPI3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
           // ILookup<HttpControllerDescriptor, ApiDescription> apiGroups = Model.ToLookup(api => api.ActionDescriptor.ControllerDescriptor);
        }
    }
}
