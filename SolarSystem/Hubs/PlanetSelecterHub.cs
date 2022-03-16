using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SolarSystem.Hubs
{
    /// <summary>
    /// This class as a part of the signalR concept and is used as an URL for the clients to call
    /// this is also called from external client like our WPF client connected to the Arduino
    /// </summary>
    public class PlanetSelecterHub : Hub
    {
        public async Task SendMessage(string planetId)
        {
            await Clients.All.SendAsync("PlanetSelecter", planetId);
        }
    }
}
