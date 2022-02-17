using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Information_and_Technology_College.Startup))]
namespace Information_and_Technology_College
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
