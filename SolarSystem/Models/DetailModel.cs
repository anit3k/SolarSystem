using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public class DetailModel
    {
        #region fields
        private int _id;
        private string _name;
        private decimal _distanceToEarth;
        private float _temperature;
        private decimal _size;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal DistanceToEarth
        {
            get { return _distanceToEarth; }
            set { _distanceToEarth = value; }
        }
        public float Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }
        public decimal Size
        {
            get { return _size; }
            set { _size = value; }
        }
        #endregion
    }
}
