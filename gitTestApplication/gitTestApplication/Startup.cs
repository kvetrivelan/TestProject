using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitTestApplication.Startup))]
namespace gitTestApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
