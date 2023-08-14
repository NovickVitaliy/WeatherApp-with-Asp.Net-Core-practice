using Microsoft.AspNetCore.Mvc;
using WeatherAppUpdated.Models;

namespace WeatherAppUpdated.ViewComponents
{
	public class CityWeatherViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(List<CityWeather> model)
		{
			return View(model);
		}
	}
}
