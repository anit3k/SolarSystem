using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Hubs
{
    public class PlanetSelecterHub : Hub
    {
        public async Task SendMessage(string planetId)
        {
            await Clients.All.SendAsync("PlanetSelecter", planetId);
        }
    }
}
