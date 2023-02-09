using TennisBookings.Shared.Weather;

namespace TennisBookings.Shared
{
	public class AmazingWeatherForecaster : IWeatherForecaster
	{
		public Task<WeatherResult> GetCurrentWeatherAsync(string city)
		{
			return Task.FromResult(new WeatherResult()
			{
				City = city,
				Weather=new WeatherCondition
				{
					Summary= "Sun"
				}
			});
		}
	}
}
