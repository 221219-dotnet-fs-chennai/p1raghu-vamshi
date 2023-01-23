using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public class UserDetails
    {
        public UserDetails() { }
        public int userId { get; set; }
        public int Age { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{userId} {Age} {Salutation} {FirstName} {MiddleName} {LastName} {Gender} {Email}";
        }
    }
}