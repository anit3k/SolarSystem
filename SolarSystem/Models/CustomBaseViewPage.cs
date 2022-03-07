using SolarSystem.Services;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System.Threading;
using Microsoft.AspNetCore.Mvc.Razor;

namespace SolarSystem.Models
{
    /// <summary>
    /// This class is used to make a custom base view template to implement an easier way to use the resource string in the HTML
    /// via the tag helpers, it works of inherits from the RazorPage<TModel> class, the services are injected using the [RazorInject] annotation,
    /// this class is abstract because we wants the .cshtml to inherits this functionality, this is done by importing it to the _ViewImports.cshtml
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public abstract class CustomBaseViewPage<TModel> : RazorPage<TModel>
    {
        [RazorInject]
        public ILanguageService LanguageService { get; set; }

        [RazorInject]
        public ILocalizationService LocalizationService { get; set; }

        public delegate HtmlString Localizer(string resourceKey, params object[] args);
        private Localizer _localizer;

        public Localizer Localize
        {
            get
            {
                if (_localizer == null)
                {
                    var currentCulture = Thread.CurrentThread.CurrentUICulture.Name;

                    var language = LanguageService.GetLanguageByCulture(currentCulture);
                    if (language != null)
                    {
                        _localizer = (resourceKey, args) =>
                        {
                            var stringResource = LocalizationService.GetStringResources(resourceKey, language.Id);

                            if (stringResource == null || string.IsNullOrEmpty(stringResource.Value))
                            {
                                return new HtmlString(resourceKey);
                            }

                            return new HtmlString((args == null || args.Length == 0)
                                ? stringResource.Value
                                : string.Format(stringResource.Value, args));
                        };
                    }
                }
                return _localizer;
            }
        }
    }

    //public abstract class CustomBaseViewPage : CustomBaseViewPage<dynamic>
    //{ }
}