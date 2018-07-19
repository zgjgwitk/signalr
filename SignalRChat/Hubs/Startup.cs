using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(SignalRChat.Habs.Startup))]
namespace SignalRChat.Habs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}