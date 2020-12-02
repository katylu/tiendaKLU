using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiTiendaLeguizamon.Startup))]
namespace MiTiendaLeguizamon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
