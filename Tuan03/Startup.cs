using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan03.Startup))]
namespace Tuan03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
