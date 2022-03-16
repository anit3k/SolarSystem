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
                new Planet{Id = 1, Name = "sun"},
                new Planet{Id = 2, Name = "mecury"},
                new Planet{Id = 3, Name = "venus"},
                new Planet{Id = 4, Name = "earth"},
                new Planet{Id = 5, Name = "moon"},
                new Planet{Id = 6, Name = "mars"},
                new Planet{Id = 7, Name = "jupiter"},
                new Planet{Id = 8, Name = "saturn"},
                new Planet{Id = 9, Name = "uranus"},
                new Planet{Id = 10, Name = "neptune"},
                new Planet{Id = 11, Name = "pluto"}

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
