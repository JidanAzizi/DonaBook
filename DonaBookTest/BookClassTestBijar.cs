using DonaBookApi.Controllers;
using DonaBookApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DonaBookClient.Models;
using System.Text.Json.Serialization;

namespace DonaBookApi.Tests
{
    [TestClass]
    public class BookControllerTests
    {
        private readonly string _filePath = Path.Combine("Data", "book.json");
        private BookController _controller;

        [TestInitialize]
        public void Setup()
        {
            Directory.CreateDirectory("Data");
            var mockBooks = new List<Book>
            {
                new Book { Id = 1, Title = "Book 1", Author = "Author 1", Genre = Genre.Fiction, Quantity = 10, State = BookState.Submitted },
                new Book { Id = 2, Title = "Book 2", Author = "Author 2", Genre = Genre.NonFiction, Quantity = 5, State = BookState.Submitted }
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
            };

            File.WriteAllText(_filePath, JsonSerializer.Serialize(mockBooks, options));

            _controller = new BookController();
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);
        }

        [TestMethod]
        public void Verify_ShouldReturnNotFound_WhenBookDoesNotExist()
        {
            // Arrange
            int nonExistentId = 999;

            // Act
            var result = _controller.Verify(nonExistentId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}