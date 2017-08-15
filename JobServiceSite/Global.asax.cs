using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using log4net.Config;
using Utility;

namespace JobServiceSite
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes); 

            XmlConfigurator.Configure();

            Log4NetHelper.WriteInfo("JobServiceSite is started.");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Log4NetHelper.WriteExcepetion(Server.GetLastError());
        }
    }
}