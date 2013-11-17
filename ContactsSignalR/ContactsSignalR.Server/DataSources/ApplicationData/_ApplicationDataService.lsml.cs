using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
using Microsoft.AspNet.SignalR;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {

        partial void Contacts_Updated(Contact entity)
        {
            string message = "A contact for " + entity.FirstName + " " + entity.LastName + " was just updated";
            var context = GlobalHost.ConnectionManager.GetHubContext<ContactHub>();
            context.Clients.All.broadcastMessage(message);
        }

        partial void Contacts_Inserted(Contact entity)
        {
            string message = "A contact for " + entity.FirstName + " " + entity.LastName + " was just created";
            var context = GlobalHost.ConnectionManager.GetHubContext<ContactHub>();
            context.Clients.All.broadcastMessage(message);
        }
    }
}
