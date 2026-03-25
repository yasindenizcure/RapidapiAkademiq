using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Net.Http.Headers;
using System.Text.Json;
namespace RapidApiAkademiq.ViewComponents
{
    public class FootballViewComponent: ViewComponent
    {
        private readonly IConfiguration _configuration;
        public FootballViewComponent(IConfiguration configuration) => _configuration = configuration;
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var apiKey = _configuration["RapidApiConfig:ApiKey"];
            var host = _configuration["RapidApiConfig:Hosts:Football"];
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{host}/api/v2/predictions?market=classic&iso_date=2026-03-23&federation=UEFA"),
                Headers =
    {
        { "x-rapidapi-key", apiKey },
        { "x-rapidapi-host", host },
    },
            };
            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<FootballViewModel.Rootobject>(jsonBody);
            return View(values);
        }
    }
}
