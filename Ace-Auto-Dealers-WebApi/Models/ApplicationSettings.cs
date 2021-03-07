using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ace_Auto_Dealers_WebApi.Models
{
    public class ApplicationSettings
    {
        public string JWT_Secret { get; set; }
        public string Client_URL { get; set; }
    }
}
