using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restoran.Startup))]
namespace Restoran
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
