using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharityWebSite.Startup))]
namespace CharityWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
