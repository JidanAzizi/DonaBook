using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using DonaBookApi.Model;

namespace DonaBookApi.Services
{
    public class UserService : IUserService
    {
        private readonly string filePath = "data/users.json";
        private List<User> users = new();

        private static readonly Dictionary<string, Func<int, string, string, string, string, string, User>> RoleMapping =
            new(StringComparer.OrdinalIgnoreCase)
            {
                { "donatur", (id, name, email, address, password, contact) => new Donatur(id, name, email, address, password, contact) },
                { "penerima", (id, name, email, address, password, contact) => new Penerima(id, name, email, address, password, contact) },
                { "volunteer", (id, name, email, address, password, contact) => new Volunteer(id, name, email, address, password, contact) }
            };

        public UserService()
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            if (!File.Exists(filePath))
            {
                users = new List<User>();
                return;
            }

            var json = File.ReadAllText(filePath);
            var rawData = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json) ?? new List<Dictionary<string, object>>();

            users = rawData
                .Select<Dictionary<string, object>, User?>(u =>
                {
                    var role = u["Role"]?.ToString() ?? "";
                    var id = Convert.ToInt32(u["Id"]);
                    var name = u["Name"]?.ToString() ?? "";
                    var email = u["Email"]?.ToString() ?? "";
                    var address = u["Address"]?.ToString() ?? "";
                    var password = u["Password"]?.ToString() ?? "";
                    var contact = u["Contact"]?.ToString() ?? "";

                    return RoleMapping.TryGetValue(role, out var createUser)
                        ? createUser(id, name, email, address, password, contact)
                        : null;
                })
                .Where(u => u != null)
                .Cast<User>()
                .ToList();
        }

        public User? Authenticate(string email, string password)
        {
            return users.FirstOrDefault(u =>
                string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase) && u.Password == password);
        }

        public List<User> GetAllUsers() => users;
    }
}
