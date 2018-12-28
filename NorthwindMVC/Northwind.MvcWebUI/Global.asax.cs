using Northwind.Entities;
using Northwind.MvcWebUI.Infrastructure;
using Northwind.MvcWebUI.ModelBinders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
//15
namespace Northwind.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //eklendi
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
            System.Web.Mvc.ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }
    }
}
