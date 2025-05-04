using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;

namespace DonaBookClient.Services
{
    public class ApiClient
    {
        private readonly HttpClient _client;

        public ApiClient()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string baseUrl = config["baseAddress"] ?? throw new Exception("baseAddress tidak ditemukan di konfigurasi.");

            _client = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public HttpClient Client => _client;
    }
}
