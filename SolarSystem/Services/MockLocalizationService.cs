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
                new StringResources{LanguageId = 1, Name = "page.lang", Value = "en"},
                new StringResources{LanguageId = 2, Name = "page.lang", Value = "hu"},
                new StringResources{LanguageId = 3, Name = "page.lang", Value = "dk"},

                new StringResources{LanguageId = 1, Name = "index.sun", Value = "Sun"},
                new StringResources{LanguageId = 2, Name = "index.sun", Value = "Nap"},
                new StringResources{LanguageId = 3, Name = "index.sun", Value = "Solen"},

                new StringResources{LanguageId = 1, Name = "index.mercury", Value = "Mercury"},
                new StringResources{LanguageId = 2, Name = "index.mercury", Value = "Merkúr"},
                new StringResources{LanguageId = 3, Name = "index.mercury", Value = "Merkur"},

                new StringResources{LanguageId = 1, Name = "index.venus", Value = "Venus"},
                new StringResources{LanguageId = 2, Name = "index.venus", Value = "Vénusz"},
                new StringResources{LanguageId = 3, Name = "index.venus", Value = "Venus"},

                new StringResources{LanguageId = 1, Name = "index.earth", Value = "Earth"},
                new StringResources{LanguageId = 2, Name = "index.earth", Value = "Föld"},
                new StringResources{LanguageId = 3, Name = "index.earth", Value = "Jorden"},

                new StringResources{LanguageId = 1, Name = "index.moon", Value = "Moon"},
                new StringResources{LanguageId = 2, Name = "index.moon", Value = "Hold"},
                new StringResources{LanguageId = 3, Name = "index.moon", Value = "Månen"},

                new StringResources{LanguageId = 1, Name = "index.mars", Value = "Mars"},
                new StringResources{LanguageId = 2, Name = "index.mars", Value = "Mars"},
                new StringResources{LanguageId = 3, Name = "index.mars", Value = "Mars"},

                new StringResources{LanguageId = 1, Name = "index.jupiter", Value = "Jupiter"},
                new StringResources{LanguageId = 2, Name = "index.jupiter", Value = "Jupiter"},
                new StringResources{LanguageId = 3, Name = "index.jupiter", Value = "Jupiter"},

                new StringResources{LanguageId = 1, Name = "index.saturn", Value = "Saturn"},
                new StringResources{LanguageId = 2, Name = "index.saturn", Value = "Szaturnusz"},
                new StringResources{LanguageId = 3, Name = "index.saturn", Value = "Saturn"},

                new StringResources{LanguageId = 1, Name = "index.uranus", Value = "Uranus"},
                new StringResources{LanguageId = 2, Name = "index.uranus", Value = "Uránusz"},
                new StringResources{LanguageId = 3, Name = "index.uranus", Value = "Uranus"},

                new StringResources{LanguageId = 1, Name = "index.neptune", Value = "Neptune"},
                new StringResources{LanguageId = 2, Name = "index.neptune", Value = "Neptunusz"},
                new StringResources{LanguageId = 3, Name = "index.neptune", Value = "Neptun"},

                new StringResources{LanguageId = 1, Name = "index.pluto", Value = "Pluto"},
                new StringResources{LanguageId = 2, Name = "index.pluto", Value = "Pluto"},
                new StringResources{LanguageId = 3, Name = "index.pluto", Value = "Pluto"}

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
