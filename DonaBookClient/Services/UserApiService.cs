using System.Net.Http.Json;
using DonaBookClient.Models;
using DonaBookApi.Model;

namespace DonaBookClient.Services
{
    public class UserApiService
    {
        private readonly HttpClient _client;

        public UserApiService()
        {
            var api = new ApiClient();
            _client = api.Client;
        }

        public async Task<User?> LoginAsync(string email, string password)
        {
            var response = await _client.PostAsJsonAsync("/api/user/login", new
            {
                Email = email,
                Password = password
            });

            if (!response.IsSuccessStatusCode)
                return null;

            var result = await response.Content.ReadFromJsonAsync<User>();
            return result;
        }

        public async Task<User?> RegisterAsync(User newUser, string password)
        {
            var fullUser = new
            {
                newUser.Name,
                newUser.Email,
                newUser.Address,
                Contact = newUser.Contact,
                Role = newUser.Role,
                Password = password
            };

            var response = await _client.PostAsJsonAsync("/api/user/register", fullUser);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<User>();
        }
    }
}
