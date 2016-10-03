using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab25.Startup))]
namespace lab25
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
