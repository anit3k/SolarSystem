using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public class Languages
    {
        private int _id;
        private string _name;
        private string _culture;
        private ICollection<StringResources> _stringResources;

        public Languages()
        {
            StringResources = new HashSet<StringResources>();
        }

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
        public string Culture
        {
            get { return _culture; }
            set { _culture = value; }
        }
        public ICollection<StringResources> StringResources
        {
            get { return _stringResources; }
            set { _stringResources = value; }
        }


    }
}
