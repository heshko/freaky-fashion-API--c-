using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FreakyFashion2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ApplicationDbContext _context;
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext contex)
        {
            _logger = logger;
            _context = contex;
        }
       

        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }

        public void OnGet()
        {
            Products = _context.Products.Include(x=>x.ProductCategory).ThenInclude(x=>x).ToList();
            Categories = _context.Categories.Take(3).ToList();

           
          
        }
    }
}
