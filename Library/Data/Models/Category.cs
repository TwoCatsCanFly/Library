﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Models {
    public class Category {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }
        public List<Book> Books { set; get; }
    }
}
