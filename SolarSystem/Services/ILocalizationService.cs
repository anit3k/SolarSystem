using SolarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Services
{
    public interface ILocalizationService
    {
        StringResources GetStringResources(string resourceKey, int languageId);
    }
}
