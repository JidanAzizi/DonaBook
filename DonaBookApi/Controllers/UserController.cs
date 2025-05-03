using DonaBookApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DonaBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>
        {
            new User(1, "Doni Dermawan", "doni@example.com", "Jl. Merdeka No. 1", "donipass", "08123456789", "donatur"),
            new User(2, "Rina Penerima", "rina@example.com", "Jl. Harapan No. 2", "rinapass", "08987654321", "penerima"),
            new User(3, "Valen Volunteer", "valen@example.com", "Jl. Sukarela No. 3", "valenpass", "08781234567", "volunteer")
        };


        [HttpGet]
        public IEnumerable<User> Get() {
            return users;
        }

        [HttpGet("{index}")]
        public User Get(int index) {
            return users[index];
        }

        [HttpPost]
        public void Post([FromBody] User user) {
            users.Add(user);
        }

        [HttpDelete("{index}")]
        public void Delete(int index) {
            users.RemoveAt(index);
        }
    }
}
