using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public record JwtOptions
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Key { get; set; }
        public string Issuer { get; set; }
    }
}
