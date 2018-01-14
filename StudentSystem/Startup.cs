using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentSystemDbContext.Startup))]
namespace StudentSystemDbContext
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
