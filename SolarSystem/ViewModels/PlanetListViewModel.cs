using SolarSystem.Dal;
using SolarSystem.Models;
using SolarSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.ViewModels
{
    public class PlanetListViewModel
    {
       
        private List<Planet> _planetList;

        public PlanetListViewModel()
        {
            PlanetList = new List<Planet>();
        }

        public List<Planet> PlanetList
        {
            get { return _planetList; }
            set { _planetList = value; }
        }


    }
}
