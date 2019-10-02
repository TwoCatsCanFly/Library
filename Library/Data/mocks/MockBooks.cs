using Library.Data.interfaces;
using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.mocks {
    public class MockBooks : IAllBooks {
        private readonly IBookCategory _categoryBooks = new MockCategory();
        public IEnumerable<Book> Books {
            get {
                return new List<Book> {
                    new Book {
                        name ="Мир в ореховой скорлупе",
                        shortDesc ="Краткое описание",
                        longDesc = "Развёрнутое описание",
                        img = "/img/book.jpg",
                        price = 450,
                        isFavourite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(1)
                    },
                    new Book {
                        name ="Да вы шутите, мистер Фейнман",
                        shortDesc ="Краткое описание",
                        longDesc = "Развёрнутое описание",
                        img = "/img/book.jpg",
                        price = 350,
                        isFavourite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(3)
                    },
                    new Book {
                        name ="Иллюзия",
                        shortDesc ="Краткое описание",
                        longDesc = "Развёрнутое описание",
                        img = "/img/book.jpg",
                        price = 250,
                        isFavourite = true,
                        available = true,
                        Category = _categoryBooks.AllCategories.ElementAt(2)
                    }
                };
            }
        }
        public IEnumerable<Book> getFavBooks { get; set; }
        public Book getObjectBook(int bookId) {throw new NotImplementedException();}
    }
}
