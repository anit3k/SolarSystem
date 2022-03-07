using SolarSystem.Models;

namespace SolarSystem.Services
{
    public interface ILocalizationService
    {
        StringResources GetStringResources(string resourceKey, int languageId);
    }
}
