using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Text.Json;

namespace RapidApiAkademiq.ViewComponents
{
    public class MovieViewComponent: ViewComponent
    {
        private readonly IConfiguration _configuration;
        public MovieViewComponent(IConfiguration configuration) => _configuration = configuration;
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var apiKey = _configuration["RapidApiConfig:ApiKey"];
            var host = _configuration["RapidApiConfig:Hosts:Movie"];

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{host}/api/imdb/most-popular-movies"),
                Headers =
    {
        { "x-rapidapi-key", apiKey },
        { "x-rapidapi-host", host },
    },
            };
            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var movieList = JsonSerializer.Deserialize<List<MovieViewModel.Class1>>(jsonBody);

            var values = new MovieViewModel.Rootobject
            {
                Property1 = movieList.ToArray()
            };

            return View(values);
        }
    }
}
