using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSWebFormsApp.Startup))]
namespace CSWebFormsApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
