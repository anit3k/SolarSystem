using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    /// <summary>
    /// This class represent the string values that are gonna be displayed
    /// into the frontend (Html) 
    /// </summary>
    public class StringResources
    {
        #region fields
        private int _id;
        private int? _languageId;
        private string _name;
        private string _value;
        private Languages _languages;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int? LanguageId
        {
            get { return _languageId; }
            set { _languageId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public Languages Languages
        {
            get { return _languages; }
            set { _languages = value; }
        }
        #endregion
    }
}
