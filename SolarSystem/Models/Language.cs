using System.Collections.Generic;

namespace SolarSystem.Models
{
    /// <summary>
    /// This model is used in many places, such as dbcontext, and as objects in lists using
    /// the translation services 
    /// </summary>
    public class Language
    {
        #region fields
        private int _id;
        private string _name;
        private string _culture;
        private ICollection<StringResources> _stringResources;
        #endregion

        #region Constructor
        public Language()
        {
            StringResources = new HashSet<StringResources>();
        }
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
        #endregion
    }
}
