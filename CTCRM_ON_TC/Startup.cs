using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CTCRM_ON_TC.Startup))]
namespace CTCRM_ON_TC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
