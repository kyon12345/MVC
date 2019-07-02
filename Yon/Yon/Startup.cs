using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yon.Startup))]
namespace Yon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
