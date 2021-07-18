using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleWebFormsApp.Startup))]
namespace SampleWebFormsApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
