using Library.Data.interfaces;
using Library.Data.Models;
using Library.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers {
    public class BooksController : Controller {
        private readonly IAllBooks _allBooks;
        private readonly IBookCategory _allCategories;

        public BooksController(IAllBooks iAllBooks, IBookCategory iBookCat) {
            _allBooks = iAllBooks;
            _allCategories = iBookCat;
        }
        [Route("Books/List")]
        [Route("Books/List/{category}")]
        public ViewResult List(string category) {
            string _category = category;
            IEnumerable<Book> books = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category)) {
                books = _allBooks.Books.OrderBy(i => i.id); }
            else {
                if (string.Equals("cook", category, StringComparison.OrdinalIgnoreCase)) {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Кулинария")).OrderBy(i => i.id);
                    currCategory = "Кулинария"; }
                
                else if (string.Equals("poetry", category, StringComparison.OrdinalIgnoreCase)) {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Поэзия")).OrderBy(i => i.id);
                    currCategory = "Поэзия"; }
                
                else if (string.Equals("sciense", category, StringComparison.OrdinalIgnoreCase)) {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Наука")).OrderBy(i => i.id);
                    currCategory = "Наука"; }
                
                else if (string.Equals("adventures", category, StringComparison.OrdinalIgnoreCase)) {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Приключения")).OrderBy(i => i.id);
                    currCategory = "Приключения"; }
                
                else if (string.Equals("scifi", category, StringComparison.OrdinalIgnoreCase)) {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Научная фантастика")).OrderBy(i => i.id);
                    currCategory = "Научная фантастика"; }
                
                else if (string.Equals("fantasy", category, StringComparison.OrdinalIgnoreCase)) {
                    books = _allBooks.Books.Where(i => i.Category.categoryName.Equals("Фентези")).OrderBy(i => i.id);
                    currCategory = "Фентези"; }

            }
            var bookObj = new BooksListViewModel {
                allBooks = books,
                currCategory = currCategory
            };

            ViewBag.Title = "Страница с книгами";
            return View(bookObj);
        }
    }
}
