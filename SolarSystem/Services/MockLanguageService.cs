using SolarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Services
{
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
