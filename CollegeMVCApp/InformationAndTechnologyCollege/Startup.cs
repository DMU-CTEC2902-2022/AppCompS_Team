using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InformationAndTechnologyCollege.Startup))]
namespace InformationAndTechnologyCollege
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
