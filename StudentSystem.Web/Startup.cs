using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentSystem.Web.Startup))]
namespace StudentSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
