using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace RealTime.Hubs
{
    public class ChartHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}