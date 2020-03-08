using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion2.Areas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

      public List<Product> GetProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }
        [HttpGet("{id}")]

        public Product GetProduct(int id)
        {
            var product= _context.Products.
                Include(x=>x.ProductCategory).ThenInclude(x=>x.Category).
                FirstOrDefault(x=>x.Id == id);
            return product;
        }
        [HttpPost]

        public ActionResult<Product> Post( Product product)
        {
            if (product == null)
            {
               return  BadRequest();
            }
            else
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return product;
            }
          
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var products = _context.Products.Any(x => x.Id == id);
            if (products)
            {
                var product = _context.Products.Find(id);
                _context.Products.Remove(product);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound("I cant found the product");
           
        }
        [HttpPut("{id}")]
        public void Put(Product product ,int id)
        {
            var pro = _context.Products.Find(id);
            pro = product;
            _context.Products.Update(pro);
            _context.SaveChanges();
        }
    }
}
