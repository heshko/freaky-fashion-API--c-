using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FreakyFashion2
{
    public class OrderConfirmationModel : PageModel
    {
        public IEnumerable<Product> Products { get; set; } = new List<Product>();

        public User user{ get; set; }
        public Address address { get; set; }
        public void OnGet(string id)
        {
            var serializedBasket = HttpContext.Session.GetString("Basket");

            if (!string.IsNullOrEmpty(serializedBasket))
            {
                Products = JsonConvert.DeserializeObject<List<Product>>(serializedBasket);
            }
            var JsonUser = HttpContext.Session.GetString("User");
            if (!string.IsNullOrEmpty(JsonUser))
            {
                user = JsonConvert.DeserializeObject<User>(JsonUser);
            }

            var JsonAddress = HttpContext.Session.GetString("Address");

            if (!string.IsNullOrEmpty(JsonAddress))
            {
                address = JsonConvert.DeserializeObject<Address>(JsonAddress);
            }
        }
    }
}