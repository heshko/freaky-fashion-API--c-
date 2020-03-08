using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion2
{
    public class CatagoryProductsModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CatagoryProductsModel(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Category Category { get; set; }
        public void OnGet( string name)
        {
            Category = _applicationDbContext.Categories.Include(x => x.ProductCategory).ThenInclude(x => x.Product).SingleOrDefault(x => x.Name == name);
        }
    }
}