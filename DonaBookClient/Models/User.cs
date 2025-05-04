using DonaBookApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DonaBookApi.Model
    {
        public class User
        {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("contact")]
        public string? Contact { get; set; }

        [JsonPropertyName("role")]
        public string? Role { get; set; }

        // Constructor kosong untuk deserialisasi JSON
        public User() { }

            // Constructor lengkap untuk manual instansiasi
            public User(int id, string name, string email, string address, string password, string contact, string role)
            {
                Id = id;
                Name = name;
                Email = email;
                Address = address;
                Password = password;
                Contact = contact;
                Role = role;
            }
        }
    }
