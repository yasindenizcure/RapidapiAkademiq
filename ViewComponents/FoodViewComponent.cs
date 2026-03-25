using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace RapidApiAkademiq.ViewComponents
{
    public class FoodViewComponent: ViewComponent
    {
        private readonly IConfiguration _configuration;
        public FoodViewComponent(IConfiguration configuration) => _configuration = configuration;
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var apiKey = _configuration["RapidApiConfig:ApiKey"];
            var host = _configuration["RapidApiConfig:Hosts:Recipe"];
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{host}/recipes/get-more-info"),
                Headers =
    {
        { "x-rapidapi-key", apiKey },
        { "x-rapidapi-host", host },
    },
            };
            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<FoodViewModel.Rootobject>(jsonBody);

            return View(values);
        }
    }
}
