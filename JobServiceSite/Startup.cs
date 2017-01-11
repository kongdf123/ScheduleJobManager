using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobServiceSite.Startup))]
namespace JobServiceSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
