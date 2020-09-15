using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebProjectCRUD.Startup))]
namespace WebProjectCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
