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
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public List<Order> GetOrders()
        {
            var orders = _context.Orders.ToList();
            return orders;
        }
        [HttpGet("{id}")]

        public Order GetOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(x => x.Id == id);
            return order;
        }
     
    }
}
