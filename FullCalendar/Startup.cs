using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullCalendar.Startup))]
namespace FullCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
