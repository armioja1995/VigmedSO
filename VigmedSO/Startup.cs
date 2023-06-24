using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VigmedSO.Startup))]
namespace VigmedSO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
