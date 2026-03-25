using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Net.Http.Headers;
using System.Text.Json;
namespace RapidApiAkademiq.ViewComponents
{
    public class FootballViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://football-prediction-api.p.rapidapi.com/api/v2/predictions?market=classic&iso_date=2026-03-23&federation=UEFA"),
                Headers =
    {
        { "x-rapidapi-key", "128bd94e78msh8a7d11cb52bce26p11b9f4jsn6129c3707d09" },
        { "x-rapidapi-host", "football-prediction-api.p.rapidapi.com" },
    },
            };
            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<FootballViewModel.Rootobject>(jsonBody);
            return View(values);
        }
    }
}
