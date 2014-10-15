using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSotre.Startup))]
namespace WebSotre
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
