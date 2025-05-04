using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DonaBookClient.Models;

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

        // GET /api/book
        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _client.GetFromJsonAsync<List<Book>>("/api/Book") ?? new List<Book>();
        }

        // Filter buku yang sudah diverifikasi
        public async Task<List<Book>> GetVerifiedBooksAsync()
        {
            var books = await GetAllBooksAsync();
            return books.Where(b => b.IsVerified).ToList();
        }

        // POST /api/book
        public async Task DonateBookAsync(Book book)
        {
            var response = await _client.PostAsJsonAsync("/api/Book", book);
            response.EnsureSuccessStatusCode();
        }

        // Simulasi pengambilan buku
        public async Task<bool> TakeBookAsync(int id)
        {
            var books = await GetAllBooksAsync();
            var book = books.FirstOrDefault(b =>
                b.Id == id && b.IsVerified && b.Quantity > 0);

            if (book == null) return false;

            book.Quantity--;

            // Karena belum ada PUT endpoint, lakukan delete lalu post ulang
            await _client.DeleteAsync($"/api/book/{id}");
            var response = await _client.PostAsJsonAsync("/api/Book", book);
            return response.IsSuccessStatusCode;
        }

        // Submit review untuk buku
        public async Task<bool> SubmitReviewAsync(int id, string review, int rating)
        {
            var payload = new
            {
                Review = review,
                Rating = rating
            };

            var response = await _client.PostAsJsonAsync($"/api/Book/review/{id}", payload);
            return response.IsSuccessStatusCode;
        }

        public async Task SubmitAsync(Book book) {
            var response = await _client.PostAsJsonAsync($"/api/Book/submit/{book.Id}", book);
            response.EnsureSuccessStatusCode();
        }

        internal async Task<bool> VerifyBookAsync(int verifId)
        {
            var books = await GetAllBooksAsync();
            var book = books.FirstOrDefault(b => b.Id == verifId);

            if (book != null) {
                book.IsVerified = true;
            }
            var response = await _client.PostAsJsonAsync($"/api/Book/verify/{verifId}", book);  
            return response.IsSuccessStatusCode;
        }
    }
}
