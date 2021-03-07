using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ace_Auto_Dealers_WebApi.Models
{
    public class Customer
    {
        [key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string? Address { get; set; }
        public string? Telephone { get; set; }
        public DateTime DateofVisit { get; set; }

        model of the vehicle
            where the customer heard
            purchase


    }
}
