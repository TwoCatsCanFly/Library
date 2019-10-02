using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Models {
    public class ShopCartItem {
        public int id { get; set; }
        public Book book { get; set; }
        public int price { get; set; }
        public string ShopCartId { get; set; }
    }
}
