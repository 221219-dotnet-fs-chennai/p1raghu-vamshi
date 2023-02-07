using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modules
{
    public class UserDetails
    {
        public string email;
        public string password;

        public UserDetails() { }
        public int userId { get; set; }
        public int Age { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                {
                    email = value;
                }
                else
                {
                    System.Console.WriteLine("Invalid Email Format");
                    System.Console.ReadLine();
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (Regex.IsMatch(value, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
                {
                    password = value;
                }
                else
                {
                    System.Console.WriteLine("Password is not Strong");
                    System.Console.ReadKey();
                }
            }
        }
        public override string ToString()
        {
            return $"{userId} {Age} {Salutation} {FirstName} {MiddleName} {LastName} {Gender} {Email} {Password}";
        }
    }
}
