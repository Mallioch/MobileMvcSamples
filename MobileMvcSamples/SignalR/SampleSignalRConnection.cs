using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileMvcSamples.SignalR
{
    public class SampleSignalRConnection : PersistentConnection
    {
        protected override System.Threading.Tasks.Task OnConnected(IRequest request, string connectionId)
        {
            Connection.Send(connectionId, "You are now connected.");

            return base.OnConnected(request, connectionId);
        }

        protected override System.Threading.Tasks.Task OnReceived(IRequest request, string connectionId, string data)
        {
            Connection.Broadcast(data);
            return base.OnReceived(request, connectionId, data);
        }

    }
}