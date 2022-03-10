using SolarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Services
{
    public class MockPlanetService : IPlanetService
    {
        private List<Planet> _planets;        


        public List<Planet> GetPlanets()
        {
            Planets = new List<Planet>
            {
                new Planet{Id = 1, Name = "Sun"},
                new Planet{Id = 2, Name = "Mecury"},
                new Planet{Id = 3, Name = "Venus"},
                new Planet{Id = 4, Name = "Earth"},
                new Planet{Id = 5, Name = "Moon"},
                new Planet{Id = 6, Name = "Mars"},
                new Planet{Id = 7, Name = "Jupiter"},
                new Planet{Id = 8, Name = "Saturn"},
                new Planet{Id = 9, Name = "Uranus"},
                new Planet{Id = 10, Name = "Neptune"},
                new Planet{Id = 11, Name = "Pluto"}

            };

            return Planets;
        }

        public List<Planet> Planets
        {
            get { return _planets; }
            set { _planets = value; }
        }
    }
}
