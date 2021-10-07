using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JamoRental.Startup))]
namespace JamoRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
