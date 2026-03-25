using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Text.Json;

namespace RapidApiAkademiq.ViewComponents
{
    public class MovieViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb236.p.rapidapi.com/api/imdb/most-popular-movies"),
                Headers =
    {
        { "x-rapidapi-key", "128bd94e78msh8a7d11cb52bce26p11b9f4jsn6129c3707d09" },
        { "x-rapidapi-host", "imdb236.p.rapidapi.com" },
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
