using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerWebApp.Models
{
    public static class BookStore
    {
        private static List<Book> books = new List<Book>()
        {
            new Book()
            {
                Id=1,
                 Name="Мойдодыр",
                Author="Моршак",
                Price=100

            },
            new Book()
            {
                Id=2,
                 Name="Колобок",
                Author="Народ",
                Price=250

            },
             new Book()
            {
                Id=3,
                 Name="Золотой телёнок",
                Author="Ильф и Петров",
                Price=800

            }
        };

        public static void AddNewBook(Book book)
        {
            book.Id = books.LastOrDefault().Id + 1;
            books.Add(book);
        }
        public static List<Book> GetAllBooks()
        {
            return books;
        }
        public static Book GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
        public static bool DeleteBookById(int id)
        {
            Book foundBook=books.FirstOrDefault(b => b.Id == id);
            //if (foundBook==null)
            //{
            //    return false;
            //}

            return books.Remove(foundBook);
        }
        public static bool UpdateBook(Book newBook)
        {
            Book foundBook = books.FirstOrDefault(b => b.Id == newBook.Id);
            if (foundBook==null)
            {
                return false;
            }
            foundBook.Name = newBook.Name;
            foundBook.Author = newBook.Author;
            foundBook.Price = newBook.Price;

            return true;
        }
    }

}
