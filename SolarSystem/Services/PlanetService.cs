using SolarSystem.Dal;
using SolarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly AppDbContext _context;

        public PlanetService(AppDbContext context)
        {
            _context = context;
        }

        public List<Planet> GetPlanets()
        {
            return _context.Planets.ToList();
        }
    }
}
