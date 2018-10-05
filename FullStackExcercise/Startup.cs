using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullStackExcercise.Startup))]
namespace FullStackExcercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
