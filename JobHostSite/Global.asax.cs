using Quartz;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Utility;

namespace JobHost
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        IScheduler scheduler;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //初始化quart.net 
            NameValueCollection config = (NameValueCollection)ConfigurationManager.GetSection("quartz");
            scheduler = QuartzNetHelper.Initialize(config);
            scheduler.Start();

        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (scheduler != null)
            {
                scheduler.Shutdown(true);
            }
        }
    }
}