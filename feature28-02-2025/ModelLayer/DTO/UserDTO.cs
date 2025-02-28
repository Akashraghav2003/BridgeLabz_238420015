using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class UserDTO
    {
        public string? FristName { get; set; }
        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? password {  get; set; }

        public override string ToString()
        {
            return $"Name{FristName} { LastName} with Email {Email}";
        }
    }
}
