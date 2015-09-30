using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TickNet.Startup))]
namespace TickNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
