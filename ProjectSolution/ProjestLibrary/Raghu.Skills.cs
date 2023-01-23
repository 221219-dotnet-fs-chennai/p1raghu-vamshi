using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjestLibrary
{
   public class Skills
    {
        public Skills() { }
        public int userId { get; set; }
        public string SkillName { get; set; }
        public override string ToString()
        {
            return $"{userId} {SkillName}  ";
        }

    }
}
