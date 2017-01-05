using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR101 
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

        public void BroadCastMessage(string messgaeFrom, string message)
        {
            Clients.All.receiveMessage(messgaeFrom, message);
        }
    }
}