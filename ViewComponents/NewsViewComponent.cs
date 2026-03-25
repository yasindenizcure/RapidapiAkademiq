using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Net.Http.Headers;
using System.Text.Json;
namespace RapidApiAkademiq.ViewComponents
{
    public class NewsViewComponent: ViewComponent
    {
        private readonly IConfiguration _configuration;
        public NewsViewComponent(IConfiguration configuration) => _configuration = configuration;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var apiKey = _configuration["RapidApiConfig:ApiKey"];
            var host = _configuration["RapidApiConfig:Hosts:News"]; 

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{host}/topic-headlines?topic=WORLD&limit=500&country=US&lang=en"),
                Headers =
        {
            { "x-rapidapi-key", apiKey },
            { "x-rapidapi-host", host },  
        },
            };

            var response = await client.SendAsync(request);
            var jsonBody = await response.Content.ReadAsStringAsync();
            var values = JsonSerializer.Deserialize<NewsViewModel.Rootobject>(jsonBody);
            return View(values);
        }

    }
}
