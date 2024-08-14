using MyExampleAPI;

namespace Ucll.OOD.Exceptions.Services;

public class ApiCallerService
{
    public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync()
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response;
        int tries = 0;

        while (true)
        {
            try
            {
                tries++;
                response = await client.GetAsync("https://localhost:7067/WeatherForecast");
                break; // success, we exit the while loop
            }
            catch
            {
                if (tries >= 5)
                {
                    throw;
                }
                Thread.Sleep(1000);
            }
        }

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecast>>();
    }
}
