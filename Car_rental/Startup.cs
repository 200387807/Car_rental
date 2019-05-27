using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Car_rental.Startup))]
namespace Car_rental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
