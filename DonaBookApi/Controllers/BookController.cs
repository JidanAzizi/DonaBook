using DonaBookApi.Model;
using DonaBookApi.Models;
using DonaBookClient.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DonaBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookSettings _settings;
        private readonly LocalizationSettings _langSettings;

        public BookController(IOptions<BookSettings> settings, IOptions<LocalizationSettings> langSettings)
        {
            _settings = settings.Value;
            _langSettings = langSettings.Value;
        }

        private JsonSerializerOptions JsonOptions => new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };

        private readonly Dictionary<string, Dictionary<string, string>> _messages = new()
        {
            ["en"] = new()
            {
                ["SubmitSuccess"] = "Book submitted.",
                ["VerifySuccess"] = "Book verified.",
                ["RejectSuccess"] = "Book rejected.",
                ["ReviewAdded"] = "Review added.",
                ["NotFound"] = "Book not found.",
                ["ReviewTooLong"] = "Review too long."
            },
            ["id"] = new()
            {
                ["SubmitSuccess"] = "Buku berhasil dikirim.",
                ["VerifySuccess"] = "Buku berhasil diverifikasi.",
                ["RejectSuccess"] = "Buku ditolak.",
                ["ReviewAdded"] = "Ulasan berhasil ditambahkan.",
                ["NotFound"] = "Buku tidak ditemukan.",
                ["ReviewTooLong"] = "Ulasan terlalu panjang."
            }
        };

        private List<Book> LoadBooks()
        {
            if (!System.IO.File.Exists(_settings.FilePath))
                return new List<Book>();

            var json = System.IO.File.ReadAllText(_settings.FilePath);
            return JsonSerializer.Deserialize<List<Book>>(json, JsonOptions) ?? new List<Book>();
        }

        private void SaveBooks(List<Book> books)
        {
            var json = JsonSerializer.Serialize(books, JsonOptions);
            System.IO.File.WriteAllText(_settings.FilePath, json);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll() => Ok(LoadBooks());

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            return book is null ? NotFound(_messages[_langSettings.Language]["NotFound"]) : Ok(book);
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

        [HttpPost("submit/{id}")]
        public IActionResult Submit(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound(_messages[_langSettings.Language]["NotFound"]);

            try
            {
                book.Submit();
                SaveBooks(books);
                return Ok(_messages[_langSettings.Language]["SubmitSuccess"]);
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
            if (book == null) return NotFound(_messages[_langSettings.Language]["NotFound"]);

            try
            {
                book.Verify();
                SaveBooks(books);
                return Ok(_messages[_langSettings.Language]["VerifySuccess"]);
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
            if (book == null) return NotFound(_messages[_langSettings.Language]["NotFound"]);

            try
            {
                book.Reject();
                SaveBooks(books);
                return Ok(_messages[_langSettings.Language]["RejectSuccess"]);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("review/{id}")]
        public IActionResult Review(int id, [FromBody] ReviewRequest input)
        {
            if (input.Review.Length > _settings.MaxReviewLength)
                return BadRequest(_messages[_langSettings.Language]["ReviewTooLong"]);

            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound(_messages[_langSettings.Language]["NotFound"]);

            book.AddReview(input.Review, input.Rating);
            SaveBooks(books);
            return Ok(_messages[_langSettings.Language]["ReviewAdded"]);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var books = LoadBooks();
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound(_messages[_langSettings.Language]["NotFound"]);

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
