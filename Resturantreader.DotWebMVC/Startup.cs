using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resturantreader.DotWebMVC.Startup))]
namespace Resturantreader.DotWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
