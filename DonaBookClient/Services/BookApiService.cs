// Lokasi: DonaBookClient/Services/BookApiService.cs
using DonaBookApi.Model;
using DonaBookClient.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DonaBookClient.Services
{
    public class BookApiService
    {
        private readonly HttpClient _client;

        public BookApiService()
        {
         
            var api = new ApiClient();
            _client = api.Client;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _client.GetFromJsonAsync<List<Book>>("/api/Book") ?? new List<Book>();
        }

        public async Task<List<Book>> GetVerifiedBooksAsync()
        {
            var books = await GetAllBooksAsync();
            return books.Where(b => b.IsVerified).ToList();
        }

        // === METODE YANG HILANG, SEKARANG DITAMBAHKAN KEMBALI ===
        public async Task<List<Book>> GetBooksWithReviewsAsync()
        {
            var verifiedBooks = await GetVerifiedBooksAsync();
            return verifiedBooks?.Where(b => !string.IsNullOrEmpty(b.Review)).ToList();
        }
        // =======================================================

        public async Task<Book> DonateBookAsync(Book book)
        {
            var response = await _client.PostAsJsonAsync("/api/Book", book);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Book>();
        }

        public async Task SubmitAsync(int bookId)
        {
            var response = await _client.PostAsync($"/api/Book/submit/{bookId}", null);
            response.EnsureSuccessStatusCode();
        }

        public async Task<bool> TakeBookAsync(int id)
        {
            // Memanggil endpoint PUT yang sudah kita tambahkan di BookController
            var response = await _client.PutAsync($"/api/book/take/{id}", null);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> SubmitReviewAsync(int id, string review, int rating)
        {
            var payload = new { Review = review, Rating = rating };
            var response = await _client.PostAsJsonAsync($"/api/Book/review/{id}", payload);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> VerifyBookAsync(int verifId)
        {
            var response = await _client.PostAsync($"/api/Book/verify/{verifId}", null);
            return response.IsSuccessStatusCode;
        }
    }
}