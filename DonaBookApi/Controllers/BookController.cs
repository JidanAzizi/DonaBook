// Lokasi: DonaBookApi/Controllers/BookController.cs

// Hanya menggunakan Model dari proyek API itu sendiri
using DonaBookApi.Model;
using DonaBookClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

// 'using DonaBookClient.Models;' sudah dihapus karena tidak sesuai dengan arsitektur yang baik.
// Server tidak seharusnya memiliki dependensi ke Client.

namespace DonaBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly string _filePath = Path.Combine("Data", "book.json");

        private JsonSerializerOptions JsonOptions => new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };

        private List<Book> LoadBooks()
        {
            if (!System.IO.File.Exists(_filePath))
                return new List<Book>();
            var json = System.IO.File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Book>>(json, JsonOptions) ?? new List<Book>();
        }

        private void SaveBooks(List<Book> books)
        {
            var json = JsonSerializer.Serialize(books, JsonOptions);
            System.IO.File.WriteAllText(_filePath, json);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll() => Ok(LoadBooks());

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            return book is null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Book newBook)
        {
            var books = LoadBooks();
            newBook.Id = books.Any() ? books.Max(b => b.Id) + 1 : 1;
            books.Add(newBook);
            SaveBooks(books);
            return CreatedAtAction(nameof(GetById), new { id = newBook.Id }, newBook);
        }

        // === ENDPOINT BARU UNTUK FITUR "AMBIL BUKU" ===
        // Metode ini dipanggil oleh TakeBookAsync dari BookApiService
        [HttpPut("take/{id}")]
        public IActionResult TakeBook(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound("Buku tidak ditemukan.");
            }

            if (book.Quantity <= 0)
            {
                return BadRequest("Stok buku sudah habis.");
            }

            book.Quantity--; // Kurangi kuantitas
            SaveBooks(books); // Simpan perubahan

            return Ok(new { message = "Buku berhasil diambil.", currentQuantity = book.Quantity });
        }
        // ===============================================

        [HttpPost("submit/{id}")]
        public IActionResult Submit(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            try
            {
                book.Submit();
                SaveBooks(books);
                return Ok("Book submitted.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("verify/{id}")]
        public IActionResult Verify(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            try
            {
                book.Verify();
                SaveBooks(books);
                return Ok("Book verified.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("reject/{id}")]
        public IActionResult Reject(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            try
            {
                book.Reject();
                SaveBooks(books);
                return Ok("Book rejected.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("review/{id}")]
        public IActionResult Review(int id, [FromBody] ReviewRequest input)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            book.AddReview(input.Review, input.Rating);
            SaveBooks(books);
            return Ok("Review added.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            books.Remove(book);
            SaveBooks(books);
            return NoContent();
        }

        public class ReviewRequest
        {
            public string Review { get; set; } = string.Empty;
            public int Rating { get; set; }
        }
    }
}