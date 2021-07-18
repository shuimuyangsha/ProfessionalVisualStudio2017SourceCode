using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSWebSite.Startup))]
namespace CSWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
