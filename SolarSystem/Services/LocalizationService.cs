using SolarSystem.Dal;
using SolarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Services
{
    public class LocalizationService : ILocalizationService
    {
        #region fields
        private readonly AppDbContext _context;
        #endregion

        #region Constructor
        public LocalizationService(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Method
        public StringResources GetStringResources(string resourceKey, int languageId)
        {
            return _context.StringResources.FirstOrDefault(st =>
               st.Name.Trim().ToLower() == resourceKey.Trim().ToLower()
               && st.LanguageId == languageId);
        }
        #endregion
    }
}
