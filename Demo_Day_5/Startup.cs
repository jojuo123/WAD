using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_Day_5.Startup))]
namespace Demo_Day_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
