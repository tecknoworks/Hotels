using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hotels.Startup))]
namespace Hotels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
