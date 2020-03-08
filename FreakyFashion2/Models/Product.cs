using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string ProductNumber { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public float Price { get; set; }

        public string UrlSlug { get; set; }
       
        public List<ProductCategory> ProductCategory { get; set; }

       
       
    }
}
