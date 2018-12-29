using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAspNet.Startup))]
namespace WebAppAspNet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
