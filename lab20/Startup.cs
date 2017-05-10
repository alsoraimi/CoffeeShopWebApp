using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab20.Startup))]
namespace lab20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
