using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetroMVC.Startup))]
namespace RetroMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
