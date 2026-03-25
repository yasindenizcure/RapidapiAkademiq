using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Text.Json;

namespace RapidApiAkademiq.ViewComponents
{
    public class QuoteViewComponent: ViewComponent
    {
        private readonly IConfiguration _configuration;
        public QuoteViewComponent(IConfiguration configuration) => _configuration = configuration;
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var apiKey = _configuration["RapidApiConfig:ApiKey"];
            var host = _configuration["RapidApiConfig:Hosts:Quote"];
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{host}/quotes"),
                Headers =
    {
        { "x-rapidapi-key", apiKey },
        { "x-rapidapi-host", host },
    },
            };
            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<QuoteViewModel.Rootobject>(jsonBody);
            return View(values);
        }
    }
}
