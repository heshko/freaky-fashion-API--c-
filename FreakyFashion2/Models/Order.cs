using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = new DateTime();
        public int UserId { get; set; }
        public User User { get; set; }
        public float Totalt { get; set; }
    }

}
