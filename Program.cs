using ServicesContracts;
using ServicesImplementations;

namespace WeatherAppUpdated
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			builder.Services.AddTransient<IWeatherService, WeatherService>();
			var app = builder.Build();

			app.UseStaticFiles();
			app.UseRouting();
			app.MapControllers();


			app.Run();
		}
	}
}