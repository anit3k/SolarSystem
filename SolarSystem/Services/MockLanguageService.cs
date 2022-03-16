using SolarSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace SolarSystem.Services
{
    /// <summary>
    /// this class represent a mock-up version of the culture/language,
    /// this is only used for the Hungarians to be able to use the code
    /// without having access to a database, this is way values are hard coded into the class
    /// </summary>
    public class MockLanguageService : ILanguageService
    {
        public IEnumerable<Language> GetLanguages()
        {
            return new List<Language>
            {
                new Language{ Id = 1, Name = "English (United States)", Culture = "en-US"},
                new Language{ Id = 2, Name = "Hungarian", Culture = "hu-HU"},
                new Language{ Id = 3, Name = "Danish", Culture = "da-DK"}
            };
        }
        public Language GetLanguageByCulture(string culture)
        {
            var language = GetLanguages();
            return language.FirstOrDefault(x => x.Culture.Trim().ToLower() == culture.Trim().ToLower());
        }

    }
}
