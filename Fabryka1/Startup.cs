using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fabryka1.Startup))]
namespace Fabryka1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
