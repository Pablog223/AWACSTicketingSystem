using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AWACSTicketWeb.StartupOwin))]

namespace AWACSTicketWeb
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
