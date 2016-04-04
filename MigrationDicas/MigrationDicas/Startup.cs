using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MigrationDicas.Startup))]
namespace MigrationDicas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
