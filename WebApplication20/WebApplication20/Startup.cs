using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication20.Startup))]
namespace WebApplication20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
