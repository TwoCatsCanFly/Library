using Library.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data {
    public class DBObjects { 
        public static void Initial(AppDBContent content) {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Book.Any()) {
                content.AddRange(
                    new Book {
                        name ="Мир в ореховой скорлупе",
                        shortDesc ="Краткое описание",
                        longDesc = "Развёрнутое описание",
                        img = "/img/book.jpg",
                        price = 450,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Кулинария"]
                    },
                    new Book {
                        name ="Да вы шутите, мистер Фейнман",
                        shortDesc ="Краткое описание",
                        longDesc = "Развёрнутое описание",
                        img = "/img/book.jpg",
                        price = 350,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Приключения"]
                    },
                    new Book {
                        name ="Иллюзия",
                        shortDesc ="Краткое описание",
                        longDesc = "Развёрнутое описание",
                        img = "/img/book.jpg",
                        price = 250,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Фентези"]
                    }


                    );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if( category == null ) {
                    var list = new Category[] {
                        new Category {categoryName = "Кулинария",desc = "Описание"},
                        new Category {categoryName = "Поэзия",desc = "Описание"},
                        new Category {categoryName = "Наука",desc = "Описание"},
                        new Category {categoryName = "Приключения",desc = "Описание"},
                        new Category {categoryName = "Научная фантастика",desc = "Описание"},
                        new Category {categoryName = "Фентези",desc = "Описание"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
