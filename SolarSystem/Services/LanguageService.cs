using SolarSystem.Dal;
using SolarSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace SolarSystem.Services
{
    /// <summary>
    /// This class implements the repository pattern and is used to get the list of
    /// cultures from the DB and to get the specific/chosen culture information 
    /// </summary>
    public class LanguageService : ILanguageService
    {
        #region fields
        private readonly AppDbContext _context;
        #endregion

        #region Constructor
        public LanguageService(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        public IEnumerable<Language> GetLanguages()
        {
            return _context.Languages.ToList();
        }
        public Language GetLanguageByCulture(string culture)
        {
            return _context.Languages.FirstOrDefault( l => 
                l.Culture.Trim().ToLower() == culture.Trim().ToLower());
        }
        #endregion
    }
}
