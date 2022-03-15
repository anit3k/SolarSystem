using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using SolarSystem.Dal;
using SolarSystem.Models;
using SolarSystem.Services;
using SolarSystem.ViewModels;
using System;
using System.Linq;

namespace SolarSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanetService _planetService;
           
        public HomeController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        public IActionResult Index()
        {
            PlanetListViewModel planets = new PlanetListViewModel();
            planets.PlanetList = _planetService.GetPlanets();

            return View(planets);
        }

        public IActionResult Detail(int id)
        {
            PlanetListViewModel planets = new PlanetListViewModel();
            planets.PlanetList = _planetService.GetPlanets();

            var planet = planets.PlanetList[id];

            return View(planet);
        }

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
