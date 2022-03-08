using SolarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Services
{
    public class MockLocalizationService : ILocalizationService
    {
        #region fields
        private List<StringResources> _stringResources;
        
        #endregion

        #region Constructor
        public MockLocalizationService()
        {
            StringResources = new List<StringResources> { 
                new StringResources{LanguageId = 1, Name = "index.greeting", Value = "Hello and welcome to our solar system model"},
                new StringResources{LanguageId = 2, Name = "index.greeting", Value = "Üdvözöljük a nap rendszerunk modeljeben"},
                new StringResources{LanguageId = 3, Name = "index.greeting", Value = "Hej og velkommen til vores solsystemmodel"}
            };
        }
        #endregion

        #region Methods
        public StringResources GetStringResources(string resourceKey, int languageId)
        {
            return StringResources.FirstOrDefault(sr => 
                sr.Name.Trim().ToLower() == resourceKey.Trim().ToLower()
                && sr.LanguageId == languageId);
        }
        #endregion

        #region Properties
        public List<StringResources> StringResources
        {
            get { return _stringResources; }
            set { _stringResources = value; }
        }
        #endregion
    }
}
