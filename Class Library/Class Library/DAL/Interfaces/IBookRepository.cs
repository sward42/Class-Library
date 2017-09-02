using Class_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.DAL.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
        IEnumerable<Book> GetUserBooks(int userId);
        Book GetSingleBook(int bookId);
        void DeleteBook(int bookId);
        void UpdateBook(Book newBook);
    }
}
