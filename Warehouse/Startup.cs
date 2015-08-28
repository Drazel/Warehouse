using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Warehouse.Startup))]
namespace Warehouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
