using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SisOAuth2._0Client.Startup))]
namespace SisOAuth2._0Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
