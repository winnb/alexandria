using Library.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Data.Services
{
    public interface IBookService
    {
        IEnumerable<Book_BW> GetAll();
        Book_BW Add(Book_BW newBook);
        Book_BW GetById(Guid id);
        void Remove(Guid id);
    }
}
