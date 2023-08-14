using Microsoft.AspNetCore.Mvc;
using ServicesContracts;

namespace WeatherAppUpdated.Controllers
{
	public class HomeController : Controller
	{
		private readonly IWeatherService _weatherService;

		public HomeController(IWeatherService weatherService)
		{
				_weatherService = weatherService;
		}

		[Route("/")]
		public IActionResult Index()
		{
			var model = _weatherService.GetWeatherDetails();
			return View(model);
		}

		[Route("/details/{cityCode}")]
		public IActionResult CityDetails(string cityCode)
		{
			var model = _weatherService.GetWeatherCityByCode(cityCode);
			

			if(model != null)
				return View("CityDetails", model);
			return Content("No city with such code has been found");
		}

		[HttpGet]
		[Route("/about")]
    public IActionResult About()
    {
      return View();
    }
	}
}
