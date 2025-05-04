using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonaBookApi.Services;
using DonaBookClient.Models;

namespace DonaBookApi.Services
{
    public interface IBookService
    {
        List<Book> GetAll();
        void Add(Book book);
        void Save();
    }
}
