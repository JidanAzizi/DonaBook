using System.Collections.Generic;
using DonaBookClient.Models;
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
            // Act
            var defaultRatings = GetGenreDefaultRatings();

            // Assert
            Assert.True(defaultRatings.ContainsKey(genre));
            Assert.Equal(expectedRating, defaultRatings[genre]);
        }

        [Fact]
        public void GenreDefaultRatings_ShouldNotContainUnknownGenre()
        {
            // Act
            var defaultRatings = GetGenreDefaultRatings();

            // Assert
            Assert.False(defaultRatings.ContainsKey(Genre.Unknown));
        }

        private static Dictionary<Genre, int> GetGenreDefaultRatings()
        {
            // Access the private static field using reflection
            var field = typeof(Book).GetField("GenreDefaultRatings",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            return (Dictionary<Genre, int>)field.GetValue(null)!;
        }
    }
}
