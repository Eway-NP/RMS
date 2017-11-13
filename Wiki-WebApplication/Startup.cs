using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wiki_WebApplication.Startup))]
namespace Wiki_WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
