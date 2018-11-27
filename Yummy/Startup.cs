using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yummy.Startup))]
namespace Yummy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
