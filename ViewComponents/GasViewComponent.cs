using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Text.Json;
using System.Net.Http.Headers;
namespace RapidApiAkademiq.ViewComponents
{
    public class GasViewComponent: ViewComponent
    {
        private readonly IConfiguration _configuration;
        public GasViewComponent(IConfiguration configuration) => _configuration = configuration;
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var apiKey = _configuration["RapidApiConfig:ApiKey"];
            var host = _configuration["RapidApiConfig:Hosts:Fuel"];

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{host}/api/petrol-prices/updates"),
                Headers =
    {
        { "x-rapidapi-key", apiKey },
        { "x-rapidapi-host", host },
    },
            };

            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<GasViewModel.Rootobject>(jsonBody);

            return View(values);
        }
    }
}
