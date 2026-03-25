using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Text.Json;
using System.Net.Http.Headers;
namespace RapidApiAkademiq.ViewComponents
{
    public class GasViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://uk-daily-fuel-prices.p.rapidapi.com/api/petrol-prices/updates"),
                Headers =
    {
        { "x-rapidapi-key", "128bd94e78msh8a7d11cb52bce26p11b9f4jsn6129c3707d09" },
        { "x-rapidapi-host", "uk-daily-fuel-prices.p.rapidapi.com" },
    },
            };

            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<GasViewModel.Rootobject>(jsonBody);

            return View(values);
        }
    }
}
