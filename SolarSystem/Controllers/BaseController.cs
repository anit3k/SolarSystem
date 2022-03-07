using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using SolarSystem.Services;
using System.Threading;

namespace SolarSystem.Controllers
{
    public class BaseController : Controller
    {
        #region fields
        private readonly ILanguageService _LanguageService;
        private readonly ILocalizationService _LocalizationService;
        #endregion

        #region Constructor
        public BaseController(ILanguageService languageService, ILocalizationService localizationService)
        {
            _LanguageService = languageService;
            _LocalizationService = localizationService;
        }
        #endregion

        /// <summary>
        /// This method is used to get the requested string resource back
        /// </summary>
        /// <param name="resourceKey">this refers to the "name" in the stringResource table in the db</param>
        /// <param name="args"></param>
        /// <returns>An Html string from with the value from the stringResource table in db</returns>
        public HtmlString Localize(string resourceKey, params object[] args)
        {
            // gets the current culture, that the end user has currently selected.
            var currentCulture = Thread.CurrentThread.CurrentUICulture.Name;

            // Gets the current language to use for correct translation
            var language = _LanguageService.GetLanguageByCulture(currentCulture);
            if (language != null) // checks if language is found
            {
                // Gets the current string resource
                var stringResource = _LocalizationService.GetStringResources(resourceKey, language.Id);
                if (stringResource == null ||string.IsNullOrEmpty(stringResource.Value)) // Checks if the string is null or empty
                {
                    return new HtmlString(resourceKey); // returns key if there is no value that matches key
                }

                // uses the conditional operator, if no arguments is given return the stringResource, else format the stringResource given the 
                // requestet argument and return this
                return new HtmlString((args == null || args.Length == 0)
                ? stringResource.Value
                : string.Format(stringResource.Value, args));
            }

            // this will return the resource key of no matching language is found
            return new HtmlString(resourceKey);
        }
    }
}
