using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Data;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FreakyFashion2
{
    public class CheckOutModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CheckOutModel(ApplicationDbContext context)
        {
            _context = context ;
        }
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        [BindProperty]
        public NewUser NewUser { get; set; }
        [BindProperty]
        public NewAddress NewAddress { get; set; }

        [BindProperty]
        public NewOrder NewOrder { get; set; }
        [BindProperty]
        public float _Totalt { get; set; }


        public void OnGet()
        {
            var serializedBasket = HttpContext.Session.GetString("Basket");

            if (!string.IsNullOrEmpty(serializedBasket))
            {
                Products = JsonConvert.DeserializeObject<List<Product>>(serializedBasket);
            }

           
        }

        public IActionResult OnPost()
        {
            var serializedBasket = HttpContext.Session.GetString("Basket");

            if (!string.IsNullOrEmpty(serializedBasket))
            {
                Products = JsonConvert.DeserializeObject<List<Product>>(serializedBasket);
            }


            if (!ModelState.IsValid)
            {
                return Page();
            }
            foreach (var product in Products)
            {
                _Totalt += product.Price;
            }
            var Newuser = new User
            {
                FirstName = NewUser.FirstName,
                LastName = NewUser.LastName,
                Email = NewUser.Email,
                TelephoneNumber = NewUser.TelephoneNumber,
                SocialSecurityNumber=NewUser.SocialSecurityNumber

                
            };
            _context.User.Add(Newuser);
            _context.SaveChanges();

            var Newaddress = new Address
            {
                UserId = Newuser.Id,
                Street = NewAddress.Street,
                City = NewAddress.Street,
                ZibCode = NewAddress.ZibCode
            };
            _context.Addresses.Add(Newaddress);
            _context.SaveChanges();
            var newOrder = new Order
            {
                UserId = Newuser.Id,
                DateTime = DateTime.Now,
                Totalt = _Totalt
                

            };
            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            var customer = new User { Id = Newuser.Id, FirstName = Newuser.FirstName, LastName = Newuser.LastName , Email = Newuser.Email };
            var JsonObject = JsonConvert.SerializeObject(customer);
            HttpContext.Session.SetString("User", JsonObject);

            var Address = new Address { Street = Newaddress.Street, City = NewAddress.City, ZibCode = Newaddress.ZibCode };
            var json = JsonConvert.SerializeObject(Address);
            HttpContext.Session.SetString("Address", json);
            return RedirectToPage("OrderConfirmation");
        }
    }

    public class NewUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string SocialSecurityNumber { get; set; }
        [Required]
        public string TelephoneNumber { get; set; }
    }
    public class NewAddress
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZibCode { get; set; }
    }
   public class NewOrder
    {
        public DateTime DateTime { get; set; } = new DateTime();
        public int UserId { get; set; }
        public User User { get; set; }
        public float Totalt { get; set; }
    }
}