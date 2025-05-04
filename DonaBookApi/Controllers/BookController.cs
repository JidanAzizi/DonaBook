using DonaBookApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization; // Tambahkan ini

namespace DonaBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly string _filePath = Path.Combine("Data", "book.json");

        private List<Book> LoadBooks()
        {
            if (!System.IO.File.Exists(_filePath))
                return new List<Book>();

            string json = System.IO.File.ReadAllText(_filePath);
            var options = new JsonSerializerOptions 
            { 
                PropertyNameCaseInsensitive = true,
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            };
            return JsonSerializer.Deserialize<List<Book>>(json, options) ?? new List<Book>();
        }

        private void SaveBooks(List<Book> books)
        {
            var options = new JsonSerializerOptions 
            { 
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            };
            string json = JsonSerializer.Serialize(books, options);
            System.IO.File.WriteAllText(_filePath, json);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            var books = LoadBooks();
            return Ok(books);
        }

        [HttpGet("{index}")]
        public ActionResult<Book> Get(int index)
        {
            var books = LoadBooks();
            if (index < 0 || index >= books.Count)
                return NotFound("Index tidak ditemukan.");
            return Ok(books[index]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book newBook)
        {
            var books = LoadBooks();
            newBook.Id = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
            books.Add(newBook);
            SaveBooks(books);
            return CreatedAtAction(nameof(Get), new { index = books.Count - 1 }, newBook);
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            var books = LoadBooks();
            if (index < 0 || index >= books.Count)
                return NotFound("Index tidak ditemukan.");
            books.RemoveAt(index);
            SaveBooks(books);
            return NoContent();
        }
    }
}