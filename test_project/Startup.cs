using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_project.Startup))]
namespace test_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
