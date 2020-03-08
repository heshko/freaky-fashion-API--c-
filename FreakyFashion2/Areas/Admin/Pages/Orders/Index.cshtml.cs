using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion2.Areas.Admin.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Order> Orders { get; set; }
        public void OnGet()
        {
            Orders = _context.Orders.Include(x=>x.User).ToList();
        }
    }
}
