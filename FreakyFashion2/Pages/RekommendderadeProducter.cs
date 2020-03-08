using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion2.Pages
{
    public class RekommendderadeProducter : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public RekommendderadeProducter(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public Category Category { get; set; }
        public Product Product { get; set; }
        public string CategoryName { get; set; }
        public List< ProductCategory> ProductCategory { get; set; }

        public IViewComponentResult Invoke(string UrlSlug)
        {
            Product = _context.Products.Include(x => x.ProductCategory).ThenInclude(x => x.Category).FirstOrDefault(x => x.UrlSlug == UrlSlug);

            CategoryName = Product.ProductCategory[0].Category.Name;

            Category = _context.Categories.Include(x => x.ProductCategory).ThenInclude(x => x.Product).FirstOrDefault(x => x.Name == CategoryName);

            ProductCategory = Category.ProductCategory.Take(4).ToList();

            return View(ProductCategory);
        }
    }
}
