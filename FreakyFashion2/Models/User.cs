using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public string SocialSecurityNumber { get; set; }
        public Address Address { get; set; }
        public List<Order>  Order { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }

        public string City { get; set; }

        public string ZibCode { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

    
}
