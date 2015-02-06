using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ULVC.Startup))]
namespace ULVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
