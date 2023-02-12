using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class Address
    {
        public Address() { }
        public int userId { get; set; }
        public long PhoneNumber { get; set; }
        public string userAddress { get; set; }
        public string country { get; set; }
        public int pincode { get; set; }

        public override string ToString()
        {
            return $"{userId}{PhoneNumber} {userAddress} {country} {pincode} ";
        }
    }
}
