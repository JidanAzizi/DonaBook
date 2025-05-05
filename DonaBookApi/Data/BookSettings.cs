// Models/BookSettings.cs
namespace DonaBookApi.Models
{
    public class BookSettings
    {
        public string FilePath { get; set; } = "Data/book.json";
        public int MaxReviewLength { get; set; } = 500;
    }
}
