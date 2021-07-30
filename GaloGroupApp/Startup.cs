using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GaloGroupApp.Startup))]
namespace GaloGroupApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
