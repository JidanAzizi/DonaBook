using System;
using System.Collections.Generic;
using System.Net.Http;
using DonaBookClient.Models;
using DonaBookClient.Services;
using Xunit;

namespace DonaBookTests
{
    public class GenreDefaultRatingsTests
    {
        [Theory]
        [InlineData(Genre.Fiction, 5)]
        [InlineData(Genre.NonFiction, 4)]
        [InlineData(Genre.ScienceFiction, 4)]
        [InlineData(Genre.Fantasy, 5)]
        [InlineData(Genre.Mystery, 4)]
        [InlineData(Genre.Romance, 3)]
        [InlineData(Genre.Horror, 4)]
        [InlineData(Genre.Biography, 4)]
        [InlineData(Genre.SelfHelp, 3)]
        [InlineData(Genre.History, 4)]
        public void GenreDefaultRatings_ShouldContainCorrectValues(Genre genre, int expectedRating)
        {
            var defaultRatings = GetGenreDefaultRatings();
            Assert.True(defaultRatings.ContainsKey(genre));
            Assert.Equal(expectedRating, defaultRatings[genre]);
        }

        [Fact]
        public void GenreDefaultRatings_ShouldNotContainUnknownGenre()
        {
            var defaultRatings = GetGenreDefaultRatings();
            Assert.False(defaultRatings.ContainsKey(Genre.Unknown));
        }

        private static Dictionary<Genre, int> GetGenreDefaultRatings()
        {
            var field = typeof(Book).GetField("GenreDefaultRatings",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            return (Dictionary<Genre, int>)field!.GetValue(null)!;
        }
    }

    public class ApiClientTests
    {
        [Fact]
        public void Constructor_ShouldInitializeHttpClientWithCorrectBaseAddress()
        {
            // Arrange
            var expectedBaseUri = new Uri("https://example.com/api/");

            // Act
            var apiClient = new ApiClient();
            var actualBaseUri = apiClient.Client.BaseAddress;

            // Assert
            Assert.NotNull(apiClient.Client);
            Assert.Equal(expectedBaseUri, actualBaseUri);
            Assert.Contains("application/json", apiClient.Client.DefaultRequestHeaders.Accept.ToString());
        }
    }
}
