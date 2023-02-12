using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class Skills
    {
        public Skills() { }
        public int userId { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public override string ToString()
        {
            return $"{userId} {SkillId} {SkillName}  ";
        }

    }
}
