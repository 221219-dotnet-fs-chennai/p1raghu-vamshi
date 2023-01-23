using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjestLibrary
{
    public class Company
    {
        public int userId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public int Experience { get; set; }
        public string CompanyEmail { get; set; }
        public string Website { get; set; }
        public override string
     ToString()
        {
            return $"{userId} {CompanyName} {CompanyLocation} {Experience} {CompanyEmail} {Website}";
        }
    }
}
