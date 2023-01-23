//using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection.Emit;

namespace ProjestLibrary
{
    public class Address
    {
        public Address() { }
        public int userId { get; set; }
        public string userAddress { get; set; }
        public string country { get; set; }
        public int pincode { get; set; }        

        public override string ToString()
        {
            return $"{userId} {userAddress} {country} {pincode} ";
        }
    }
}
