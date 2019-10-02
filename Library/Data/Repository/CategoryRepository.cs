using Library.Data.interfaces;
using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Repository {
    public class CategoryRepository : IBookCategory {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent) { this.appDBContent = appDBContent; }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
