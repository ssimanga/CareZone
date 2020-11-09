using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CareZone.WebUI.Startup))]
namespace CareZone.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
