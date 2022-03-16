using SolarSystem.Models;

namespace SolarSystem.Services
{
    /// <summary>
    /// This interface is key to all translation, but in mockup and database enviroment
    /// </summary>
    public interface ILocalizationService
    {
        /// <summary>
        /// gets the value from the requested translation
        /// </summary>
        /// <param name="resourceKey">the name of the resource</param>
        /// <param name="languageId">Id of the current selected culture</param>
        /// <returns></returns>
        StringResources GetStringResources(string resourceKey, int languageId);
    }
}
