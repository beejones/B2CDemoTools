using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B2CAppMvc.Startup))]
namespace B2CAppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
