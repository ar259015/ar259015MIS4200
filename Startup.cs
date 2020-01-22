using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ar259015MIS4200.Startup))]
namespace ar259015MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
