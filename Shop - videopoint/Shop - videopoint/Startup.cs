using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shop___videopoint.Startup))]
namespace Shop___videopoint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
