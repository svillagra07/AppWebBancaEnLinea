using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWebBancaEnLinea.Startup))]
namespace AppWebBancaEnLinea
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
