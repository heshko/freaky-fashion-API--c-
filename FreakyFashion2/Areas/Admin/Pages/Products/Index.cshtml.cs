using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion2.Areas.Admin.Pages.Products
{
    public class IndexModel : PageModel
    {

        public readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet =true)]
        public string Search { get; set; }
        public IList<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Products.Include(x => x.ProductCategory).ThenInclude(x => x.Category).ToList();

            if (!string.IsNullOrEmpty(Search))
            {
                Products = Products.Where(x => x.Name.Contains(Search)).ToList();
            }
        }
    }
}
