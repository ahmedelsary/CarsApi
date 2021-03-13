using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ace_Auto_Dealers_WebApi.Models
{
   public enum VehicleModelType
    {
        BRZ,
        Impreza,
        WRX,
        Legacy,
        Forester,
        Crosstrek,
        Outback,
        Ascent
    };

    public class Customer
    {
        [key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string SalesRepresentativeId { get; set; }
        public string SalesRepresentativeName { get; set; }
        public string? Address { get; set; }
        public string? Telephone { get; set; }
        public DateTime DateofVisit { get; set; }
        public int VehicleModel { get; set; }
        public string HeardFrom { get; set; }
        public bool? Purchase { get; set; }
      





    }
}
