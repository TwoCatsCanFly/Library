using Library.Data.interfaces;
using Library.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers {
    public class HomeController :Controller {
        private IAllBooks _bookRep;

        public HomeController(IAllBooks bookRep) {
            _bookRep = bookRep;
        }

        public ViewResult Index() {
            var homeBooks = new HomeViewModel {
                favBooks = _bookRep.getFavBooks
            };
            return View(homeBooks);
        }
    }
}
