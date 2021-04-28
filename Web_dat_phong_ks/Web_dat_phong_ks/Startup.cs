using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_dat_phong_ks.Startup))]
namespace Web_dat_phong_ks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
