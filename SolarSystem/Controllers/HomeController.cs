using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using SolarSystem.Services;
using SolarSystem.ViewModels;
using System;
using System.Linq;

namespace SolarSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanetService _planetService;
         
        /// <summary>
        /// constructor with dependency injection, the service is used to read the name and id of the planets
        /// and load the information into the view model
        /// </summary>
        /// <param name="planetService"></param>
        public HomeController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        /// <summary>
        /// This method is called to get the index view, here we use a ViewModel to 
        /// get id of the planets
        /// </summary>
        /// <returns>Index view</returns>
        public IActionResult Index()
        {
            PlanetListViewModel planets = new PlanetListViewModel();
            planets.PlanetList = _planetService.GetPlanets();
            return View(planets);
        }

        /// <summary>
        /// This page shows to detail on the requested planet
        /// </summary>
        /// <param name="id">Id of planet from 1 to 11</param>
        /// <returns>The details about the specific planet</returns>
        public IActionResult Detail(int id)
        {
            // if planet id is unknown redirect back to index site
            if (id < 1 || id > 11)
            {
                return new RedirectResult(url: "/Home/Index", permanent: true,
                             preserveMethod: true);
            }
            PlanetListViewModel planets = new PlanetListViewModel();
            planets.PlanetList = _planetService.GetPlanets();

            var planet = planets.PlanetList.FirstOrDefault(x => x.Id == id);

            return View(planet);
        }

        /// <summary>
        /// This page is used to simulate the star dust feature we 
        /// sow in the planetarium
        /// </summary>
        /// <returns></returns>
        public IActionResult Stardust()
        {
            return View();
        }

        /// <summary>
        /// This method is called when you change the language, and saves the users choise in
        /// a cookie on the local machine
        /// </summary>
        /// <param name="culture">the selected culture code</param>
        /// <param name="returnUrl">return url address</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ChangeLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(7)
                }
            );
            return LocalRedirect(returnUrl);
        }
    }
}
