using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication13.Startup))]
namespace WebApplication13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
