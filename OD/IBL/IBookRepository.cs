using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IBL
{
    public interface IBookRepository
    {
        IEnumerable<BookModel> GetAllBooks();
        int AddBook(BookModel objBookModel);
        BookModel GetBookByBookId(int id);
    }
}
