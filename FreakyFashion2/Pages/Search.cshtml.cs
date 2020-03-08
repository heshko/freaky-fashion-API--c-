using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreakyFashion2
{
    public class SearchModel : PageModel
    {
        private readonly ApplicationDbContext _context;

       
       
        public SearchModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet =true)]
        public string q { get; set; }
        public List<Product>  Products { get; set; }
        public string  ProductName { get; set; }
        public void OnGet( )
        {
            ProductName = q;
            Products = _context.Products.ToList();
            if (!string.IsNullOrEmpty(q))
            {
                Products = _context.Products.Where(x => x.Name == q).ToList();
            }
         
          
        }
    }
}