using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Services
{
    public class ComponentHub : Hub
    {
        public void AddEncounterGroup(string pageKey)
        {
            this.Groups.Add(this.Context.ConnectionId, pageKey);
        }

        public void DispatchObjectToChild(string identifer, StateModel model)
        {
            Clients.Group(identifer).dispatchObjectToChild(model);            
        }

        public void DispatchCloseCommand(string pageKey)
        {
            Clients.Group(pageKey).closeChild();
        }

        public void UpdateChildText(string pageKey)
        {
            Clients.Group(pageKey).updateEncounterText("New Text from next encounter");
        }

        public void SendParentClosingAction(string pageKey)
        {
            Clients.Group(pageKey).childIsClosing();
        }

        public class StateModel
        {
            public string Id { get; set; }
            public string Action { get; set; }
        }
    }
}
