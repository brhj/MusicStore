using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(musicstore.Startup))]
namespace musicstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
