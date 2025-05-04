using DonaBookApi.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DonaBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly string _filePath = Path.Combine("Data", "user.json");

        private JsonSerializerOptions JsonOptions => new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };

        private List<User> LoadUsers()
        {
            if (!System.IO.File.Exists(_filePath))
                return new List<User>();

            var json = System.IO.File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<User>>(json, JsonOptions) ?? new List<User>();
        }

        private void SaveUsers(List<User> users)
        {
            var json = JsonSerializer.Serialize(users, JsonOptions);
            System.IO.File.WriteAllText(_filePath, json);
        }

        // GET: api/user
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll() => Ok(LoadUsers());

        // GET: api/user/1
        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Id == id);
            return user is null ? NotFound() : Ok(user);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User newUser)
        {
            var users = LoadUsers();

            if (users.Any(u => u.Email == newUser.Email))
                return Conflict("Email sudah terdaftar.");

            // ✅ Validasi role
            var allowedRoles = new[] { "donatur", "penerima", "volunteer" };
            if (!allowedRoles.Contains(newUser.Role.ToLower()))
                return BadRequest("Role harus salah satu dari: donatur, penerima, volunteer.");

            newUser.Id = users.Any() ? users.Max(u => u.Id) + 1 : 1;
            users.Add(newUser);
            SaveUsers(users);
            return CreatedAtAction(nameof(GetById), new { id = newUser.Id }, newUser);
        }


        // POST: api/user/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest login)
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Email == login.Email && u.Password == login.Password);

            if (user == null)
                return Unauthorized("Email atau password salah.");

            return Ok(new
            {
                message = "Login berhasil.",
                user.Id,
                user.Name,
                user.Role,
                redirect = user.Role.ToLower() switch
                {
                    "donatur" => "/api/book",
                    "penerima" => "/api/book",
                    "volunteer" => "/api/book/verify",
                    _ => "/api/user"
                }
            });
        }

        // DELETE: api/user/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound("User tidak ditemukan.");

            users.Remove(user);
            SaveUsers(users);
            return NoContent();
        }

        public class LoginRequest
        {
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }
    }
}