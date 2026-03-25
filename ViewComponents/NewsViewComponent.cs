using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Net.Http.Headers;
using System.Text.Json;
namespace RapidApiAkademiq.ViewComponents
{
    public class NewsViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() 
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-news-data.p.rapidapi.com/topic-headlines?topic=WORLD&limit=500&country=US&lang=en"),
                Headers =
    {
        { "x-rapidapi-key", "128bd94e78msh8a7d11cb52bce26p11b9f4jsn6129c3707d09" },
        { "x-rapidapi-host", "real-time-news-data.p.rapidapi.com" },
    },
            };
            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<NewsViewModel.Rootobject>(jsonBody);
            return View(values);
        }

    }
}
