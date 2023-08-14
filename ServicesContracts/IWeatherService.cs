using WeatherAppUpdated.Models;

namespace ServicesContracts
{
	public interface IWeatherService
	{
		List<CityWeather> GetWeatherDetails();
		CityWeather? GetWeatherCityByCode(string code);
	}
}