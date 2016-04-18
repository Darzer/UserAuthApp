using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserAuthApp.Startup))]
namespace UserAuthApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
