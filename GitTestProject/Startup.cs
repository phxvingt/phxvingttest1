using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTestProject.Startup))]
namespace GitTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
