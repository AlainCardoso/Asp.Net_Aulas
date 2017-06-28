using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(G4meroom.Startup))]
namespace G4meroom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
