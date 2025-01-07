// File: Services/BookService.cs
using Perpustakaan.Models;
using System.Collections.Generic;
using System.Linq;

namespace Perpustakaan.Services
{
    public class BookService
    {
        private readonly List<Book> books = new();

        public IEnumerable<Book> GetBooks() => books;

        public void AddBook(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book);
        }
    }
}
