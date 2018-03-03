using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(mobappquickService.Startup))]

namespace mobappquickService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}