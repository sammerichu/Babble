using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBabble.Startup))]
namespace TheBabble
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
