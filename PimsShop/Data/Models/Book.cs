using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PimsShop.Data.Models
{
    public class Book
    {
        public int id { set; get; }
        public string bookName { set; get; }
        public string shortDescription { set; get; }
        public string longDescription { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }

        public bool isFavorite { set; get; }
        public int available { set; get; }

        public int categoryId { set; get; }

        public virtual Category category { set; get; }

    }
}
