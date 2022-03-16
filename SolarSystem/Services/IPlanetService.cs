using SolarSystem.Models;
using System.Collections.Generic;

namespace SolarSystem.Services
{
    /// <summary>
    /// This interface is used for the planet service,
    /// but is only used internally as an identifier of the planet in html etc. 
    /// </summary>
    public interface IPlanetService
    {
        /// <summary>
        /// Gets all the current planets
        /// </summary>
        /// <returns>List of all planets</returns>
        List<Planet> GetPlanets();
    }
}
