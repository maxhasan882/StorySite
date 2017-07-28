using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StorySite.Startup))]
namespace StorySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
