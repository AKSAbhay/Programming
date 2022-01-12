using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using IBL;
using Models;

namespace Buiness_Logic
{
    internal class BookRepository : IBookRepository
    {

        private ProductsDBEntities bookDBModel;
        public BookRepository()
        {
            bookDBModel = new ProductsDBEntities();
        }
        public IEnumerable<BookModel> GetAllBooks()
        {
            IEnumerable<BookModel> listOfBooks = (from objBook in ProductsDBEntities.tblProducts
                                                  select new BookModel()
                                                  {
                                                      Author = objBook.Name,

                                                  }
                                                  ).ToList();
            return listOfBooks;
        }

        public int AddBook(BookModel objBookModel)
        {
            throw new NotImplementedException();
        }

        public BookModel GetBookByBookId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
