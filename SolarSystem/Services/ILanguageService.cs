using SolarSystem.Models;
using System.Collections.Generic;

namespace SolarSystem.Services
{
    /// <summary>
    /// This interface is used to get all the languages, and get the selected culture
    /// It uses a simple repository pattern
    /// </summary>
    public interface ILanguageService
    {
        IEnumerable<Language> GetLanguages();
        Language GetLanguageByCulture(string culture);
    }
}
