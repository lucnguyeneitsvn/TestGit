using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DemoLiveChat.LCSK.Startup))]

namespace DemoLiveChat.LCSK
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            string sub = "1234";
            string.Format("a", "12");
            var hehe = 1;
            var nana = "some";
            var its = 123;
        }
    }
}
