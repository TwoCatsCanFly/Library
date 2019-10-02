using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.interfaces {
    public interface IAllBooks {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> getFavBooks { get; }
        Book getObjectBook(int bookId);
    }
}
