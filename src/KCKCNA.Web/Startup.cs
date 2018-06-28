using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KCKCNA.Web.Startup))]
namespace KCKCNA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
