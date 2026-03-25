using Microsoft.AspNetCore.Mvc;
using RapidApiAkademiq.Models;
using System.Text.Json;

namespace RapidApiAkademiq.ViewComponents
{
    public class CryptoViewComponent: ViewComponent
    {
        private readonly IConfiguration _configuration;
        public CryptoViewComponent(IConfiguration configuration) => _configuration = configuration;
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var apiKey = _configuration["RapidApiConfig:ApiKey"];
            var host = _configuration["RapidApiConfig:Hosts:Crypto"];

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{host}/coins?referenceCurrencyUuid=yhjMzLPhuIDl&timePeriod=24h&orderBy=marketCap&orderDirection=desc&limit=50&offset=0"),
                Headers =
    {
        { "x-rapidapi-key", apiKey },
        { "x-rapidapi-host", host },
    },
            };

            var response = await client.SendAsync(request);

            var jsonBody = await response.Content.ReadAsStringAsync();

            var values = JsonSerializer.Deserialize<CryptoViewModel.Rootobject>(jsonBody);
            return View(values);
        }
    }
}
