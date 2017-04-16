using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SushiBar.Web.Startup))]
namespace SushiBar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
