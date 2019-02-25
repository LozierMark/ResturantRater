using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restaurantreader.DotWebMVC.Startup))]
namespace Restaurantreader.DotWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
