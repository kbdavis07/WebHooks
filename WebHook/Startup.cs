using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHook.Startup))]
namespace WebHook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
