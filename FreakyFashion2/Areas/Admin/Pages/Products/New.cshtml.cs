using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreakyFashion2.Areas.Admin.Pages.Products
{
    public class NewModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        public NewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Category> categories { get; set; }
        public Product product { get; set; }
        public ProductCategory  ProductCategory { get; set; }
         [BindProperty]
        public NewProduct NewProduct { get; set; }
        public void OnGet()
        {
            categories = _context.Categories.ToList();
        }

        public IActionResult OnPost()
        {
            categories = _context.Categories.ToList();
            if (!ModelState.IsValid)
            {
                return Page();
            }
            product = new Product
            {
                Name = NewProduct.Name,
                ProductNumber = NewProduct.ProductNumber,
                Price = NewProduct.Price,
                Description = NewProduct.Description,
                ImageUrl = NewProduct.ImageUrl,
                UrlSlug = NewProduct.Name.Replace(" ", "-")
            };
            _context.Products.Add(product);
            _context.SaveChanges();



            
            foreach(var i in NewProduct.CategoriesId)
            {
              var  ProductCategory_ = new ProductCategory
                {
                    ProductId = product.Id,
                    CategoryId = i
                };
                _context.ProductCategories.Add(ProductCategory_);
                _context.SaveChanges();
            }
            
            return Redirect("/Admin/Products");
        }
    }
   public class NewProduct
    {
        [Required(ErrorMessage = "You should write somthing here"), Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You should write somthing here"), Display(Name = "ProductNumber")]
        public string ProductNumber { get; set; }
        [Required(ErrorMessage = "You should write somthing here"), Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "You should write somthing here"), Display(Name = "ImageUrl")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "You should write somthing here"), Display(Name = "Price")]
        public float Price { get; set; }

        [Required]
        public List<int>CategoriesId { get; set; }
        
    }
}
