// Lokasi: DonaBookClient/Services/ApiClient.cs
using System;
using System.IO;
using System.Net.Http;
using Microsoft.Extensions.Configuration; // <-- Tambahkan using ini

namespace DonaBookClient.Services
{
    public class ApiClient
    {
        public HttpClient Client { get; }
        private static IConfiguration _configuration;

        public ApiClient()
        {
            // Membangun konfigurasi dari file appsettings.json
            // File ini akan dibaca dari direktori output saat aplikasi GUI berjalan
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();

            // Mengambil BaseUrl dari konfigurasi dan membuat HttpClient
            string baseUrl = _configuration["ApiBaseUrl"];
            if (string.IsNullOrEmpty(baseUrl))
            {
                // Fallback jika URL tidak ditemukan di appsettings.json
                throw new Exception("ApiBaseUrl tidak ditemukan di appsettings.json");
            }

            Client = new HttpClient { BaseAddress = new Uri(baseUrl) };
        }
    }
}