using Library.Data.interfaces;
using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.mocks {
    public class MockCategory : IBookCategory {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category {categoryName = "Кулинария",desc = "Описание"},
                    new Category {categoryName = "Поэзия",desc = "Описание"},
                    new Category {categoryName = "Наука",desc = "Описание"},
                    new Category {categoryName = "Приключения",desc = "Описание"},
                    new Category {categoryName = "Научная фантастика",desc = "Описание"},
                    new Category {categoryName = "Фентези",desc = "Описание"}
                };
            }
        }
    }
}
