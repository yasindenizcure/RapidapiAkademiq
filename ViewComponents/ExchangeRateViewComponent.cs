using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Text.Json;

namespace RapidApiAkademiq.ViewComponents
{
    public class ExchangeRateViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()

        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://exchange-rates7.p.rapidapi.com/latest?base=USD"),
                Headers =
    {
        { "x-rapidapi-key", "128bd94e78msh8a7d11cb52bce26p11b9f4jsn6129c3707d09" },
        { "x-rapidapi-host", "exchange-rates7.p.rapidapi.com" },
    },
            };
            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<ExchangeRateViewModel.Rootobject>(jsonBody);
            return View(values);
        }
    }

}