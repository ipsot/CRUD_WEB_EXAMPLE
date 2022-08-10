using ServerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerWebApp.Controllers
{
    public class BooksController : ApiController
    {
        [HttpPost]
        public List<Book> GetAllBooks()
        {
            return BookStore.GetAllBooks();
        }
        [HttpPost]
        public Book GetBookById([FromBody]int id)
        {
            return BookStore.GetBookById(id);
        }
        [HttpPost]
        public bool DeleteBookById([FromBody] int id)
        {
            return BookStore.DeleteBookById(id);
        }
        [HttpPost]
        public bool UpdateBook([FromBody] Book newBook)
        {
            return BookStore.UpdateBook(newBook);
        }
        [HttpPost]
        public void AddNewBook([FromBody] Book book)
        {
            BookStore.AddNewBook(book);
        }


    }
}
