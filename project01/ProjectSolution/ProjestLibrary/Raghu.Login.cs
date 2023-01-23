using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjestLibrary
{
    public class Login
    {
        public Login() { }
        public int userId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $"{userId} {Password} {Email}";
        }
    }
}
