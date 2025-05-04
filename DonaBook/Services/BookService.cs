using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kpl_tubes.Model;
using System.Text.Json;
using Kpl_tubes.Services.kpl_tubes.Services;

namespace kpl_tubes.Services
{
    public class BookService : IBookService
    {
        private readonly string filePath = "data/books.json";
        private List<Book> books = new();

        public BookService()
        {
            Load();
        }

        public void Load()
        {
            if (!File.Exists(filePath))
            {
                books = new List<Book>();
                return;
            }

            var json = File.ReadAllText(filePath);
            books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
        }

        public void Add(Book book)
        {
            book.Id = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
            books.Add(book);
            Save();
        }

        public List<Book> GetAll() => books;

        public void Save()
        {
            var json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public List<Book> Search(string? title = null, string? author = null, string? genre = null)
        {
            return books.Where(b =>
                (string.IsNullOrEmpty(title) || b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(author) || b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(genre) || b.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase))
            ).ToList();
        }
    }
}
