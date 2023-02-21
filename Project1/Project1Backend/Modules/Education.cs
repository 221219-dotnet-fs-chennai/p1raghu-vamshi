using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class Education
    {
        //public Education() { }
        public int userId { get; set; }
        public int RollNo { get; set; }
        public string University { get; set; }
        public string UG { get; set; }
        public string Specialization { get; set; }
        public int PassedOutYear { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{userId} {RollNo} {University} {UG} {Specialization} {PassedOutYear} {Grade}";
        }
    }
}
