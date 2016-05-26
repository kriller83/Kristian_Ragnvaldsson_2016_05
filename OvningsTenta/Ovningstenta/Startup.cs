using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ovningstenta.Startup))]
namespace Ovningstenta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
