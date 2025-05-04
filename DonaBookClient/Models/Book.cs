using System;
using System.Collections.Generic;



namespace DonaBookClient.Models
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        ScienceFiction,
        Fantasy,
        Mystery,
        Romance,
        Horror,
        Biography,
        SelfHelp,
        History,
        Unknown
    }

    public enum Category
    {
        AnakAnak,
        Remaja,
        Dewasa,
        Pendidikan,
        Lainnya
    }

    public enum BookCondition
    {
        Baru,
        BekasBaik,
        BekasRusak
    }

    public enum BookState
    {
        Draft,
        Submitted,
        Verified,
        Rejected
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;

        public Genre Genre { get; set; }
        public Category Category { get; set; }
        public BookCondition Condition { get; set; }

        public int Quantity { get; set; }
        public bool IsVerified { get; set; } = false;
        public string? Review { get; set; }
        public int Rating { get; set; }

        public BookState State { get; set; } = BookState.Draft;

        public Book() { }

        public Book(string title, string publisher, Genre genre, string author, Category category, BookCondition condition, int quantity)
        {
            Title = title;
            Publisher = publisher;
            Genre = genre;
            Author = author;
            Category = category;
            Condition = condition;
            Quantity = quantity;
            IsVerified = false;
            State = BookState.Draft;

            Rating = GenreDefaultRatings.ContainsKey(genre) ? GenreDefaultRatings[genre] : 0;
        }

        public void Submit()
        {
            if (State != BookState.Draft)
                throw new InvalidOperationException("Buku hanya bisa diajukan dari status Draft.");
            State = BookState.Submitted;
        }

        public void Verify()
        {
            if (State != BookState.Submitted)
                throw new InvalidOperationException("Hanya buku yang diajukan yang bisa diverifikasi.");
            IsVerified = true;
            State = BookState.Verified;
        }

        public void Reject()
        {
            if (State != BookState.Submitted)
                throw new InvalidOperationException("Hanya buku yang diajukan yang bisa ditolak.");
            State = BookState.Rejected;
        }

        public void AddReview(string review, int rating)
        {
            Review = review;
            Rating = rating;
        }

        private static readonly Dictionary<Genre, int> GenreDefaultRatings = new()
        {
            { Genre.Fiction, 5 },
            { Genre.NonFiction, 4 },
            { Genre.ScienceFiction, 4 },
            { Genre.Fantasy, 5 },
            { Genre.Mystery, 4 },
            { Genre.Romance, 3 },
            { Genre.Horror, 4 },
            { Genre.Biography, 4 },
            { Genre.SelfHelp, 3 },
            { Genre.History, 4 }
        };
    }
}
