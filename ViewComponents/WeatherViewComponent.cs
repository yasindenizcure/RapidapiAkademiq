using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Text.Json;

namespace RapidApiAkademiq.ViewComponents
{
    public class WeatherViewComponent: ViewComponent
    {
        private readonly IConfiguration _configuration;
        public WeatherViewComponent(IConfiguration configuration) => _configuration = configuration;
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var apiKey = _configuration["RapidApiConfig:ApiKey"];
            var host = _configuration["RapidApiConfig:Hosts:Weather"];
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{host}/fivedaysforcast?latitude=41.00&longitude=28.97&units=metric&lang=tr"),
                Headers =
    {
        { "x-rapidapi-key", apiKey },
        { "x-rapidapi-host", host},
    },
            };

            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<WeatherViewModel.Rootobject>(jsonBody);
            return View(values);
        }
    }
}
