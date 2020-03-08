using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FreakyFashion2
{
    public class ProductModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductModel(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        [BindProperty]
        public Product Product { get; set; }

        

        // public Category  Category { get; set; }

        //   public List<ProductCategory> ProductCategory { get; set; }
        // public string CategoryName { get; set; }
        /*
         public async Task OnGetAsync(string UrlSlug )
         {
             Product = _applicationDbContext.Products.Include(x=>x.ProductCategory).ThenInclude(x=>x.Category).FirstOrDefault(x=>x.UrlSlug == UrlSlug);

             CategoryName = Product.ProductCategory[0].Category.Name;

             Category = await _applicationDbContext.Categories.Include(x => x.ProductCategory).ThenInclude(x => x.Product).FirstAsync(x => x.Name == CategoryName);

             ProductCategory = Category.ProductCategory.Take(4).ToList();

         }
         */
        public IActionResult OnGet(string urlSlug)
        {
            Product = _applicationDbContext.Products
                .FirstOrDefault(x => x.UrlSlug == urlSlug);

            if (Product == null)
            {
                return NotFound();
            }

            return Page();

           

        }

        public IActionResult OnPost()
        {
            var serializedBasket = HttpContext.Session.GetString("Basket");
            

            var basket = new List<Product>();

            if (serializedBasket != null)
            {
                basket = JsonConvert.DeserializeObject<List<Product>>(serializedBasket);
            }

            Product = _applicationDbContext.Products
                   .FirstOrDefault(x => x.Id == Product.Id);

            basket.Add(Product);

            serializedBasket = JsonConvert.SerializeObject(basket);

            HttpContext.Session.SetString("Basket", serializedBasket);

            return RedirectToPage("Basket");
            
        }
    }
}