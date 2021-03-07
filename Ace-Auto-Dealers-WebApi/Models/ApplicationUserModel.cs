using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ace_Auto_Dealers_WebApi.Models
{
    public enum RoleType { Adminstrator, SalesRepresentative }
    public class ApplicationUserModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public RoleType Role { get; set; }
    }
}
