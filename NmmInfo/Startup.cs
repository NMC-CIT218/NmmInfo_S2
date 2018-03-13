using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NmmInfo.Startup))]
namespace NmmInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
