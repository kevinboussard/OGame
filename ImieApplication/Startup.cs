using ImieApplication.Database;
using ImieApplication.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImieApplication.Startup))]
namespace ImieApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
