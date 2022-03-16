using SolarSystem.Models;
using System.Collections.Generic;

namespace SolarSystem.ViewModels
{
    public class PlanetListViewModel
    {
        #region fields
        private List<Planet> _planetList;
        #endregion

        #region Constructor
        public PlanetListViewModel()
        {
            PlanetList = new List<Planet>();
        }
        #endregion

        #region Properties
        public List<Planet> PlanetList
        {
            get { return _planetList; }
            set { _planetList = value; }
        }
        #endregion☻
    }
}
