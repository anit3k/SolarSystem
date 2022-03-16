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
        /// <summary>
        /// Gets a list of all supported languages
        /// </summary>
        /// <returns></returns>
        IEnumerable<Language> GetLanguages();
        /// <summary>
        /// Gets the language of the requested culture
        /// </summary>
        /// <param name="culture"></param>
        /// <returns></returns>
        Language GetLanguageByCulture(string culture);
    }
}
