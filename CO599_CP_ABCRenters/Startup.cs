using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CO599_CP_ABCRenters.Startup))]
namespace CO599_CP_ABCRenters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
