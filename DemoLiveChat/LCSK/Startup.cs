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
            var nana = 12;
            var j = "abc";
        }
    }
}
