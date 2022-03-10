using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public class Planet
    {
        private int _id;

        private string _planetName;

        public string Name
        {
            get { return _planetName; }
            set { _planetName = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
