using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lohith_1622120_WA.Startup))]
namespace Lohith_1622120_WA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
