using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion2.Areas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public List<Category> GetCategories()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }

        [HttpGet("{id}")]

        public Category GetCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            return category;
        }
    }
}
