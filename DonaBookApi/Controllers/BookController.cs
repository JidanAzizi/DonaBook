using DonaBookApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DonaBookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> bookList = new List<Book>()
        {
            new Book("Terangkanlah", "PT Gramedia", Genre.SelfHelp,"Yudha Harwanto", Category.Lainnya, BookCondition.Baru, 22, 001),
            new Book("Cinderella Tanpa Nama", "Good Dreamer", Genre.Romance,"Patricia Alodie", Category.Remaja, BookCondition.BekasRusak, 44, 002),
            new Book("Jejak Sang Jenius", "CV  Langganan Pustaka", Genre.History,"Oellien NoehaRisma Desliana", Category.Lainnya, BookCondition.BekasBaik, 88, 003)
        };

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return bookList;
        }

        [HttpGet("{index}")]
        public Book Get(int index)
        {
            return bookList[index];
        }

        [HttpPost]
        public void Post([FromBody] Book bku)
        {
            bookList.Add(bku);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            bookList.RemoveAt(index);
        }

    }
}
