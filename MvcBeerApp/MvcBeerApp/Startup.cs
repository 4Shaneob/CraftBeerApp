using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcBeerApp.Startup))]
namespace MvcBeerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
