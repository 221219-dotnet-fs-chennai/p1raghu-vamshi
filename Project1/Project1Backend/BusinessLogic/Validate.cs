using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ef=EntityApi.Entities;
using Modules;

namespace BusinessLogic
{
    public class Validate
    {

        ef.AssociatesDbContext  context;
        public Validate(ef.AssociatesDbContext context)
        {
            this.context = context;
        }

        public int Pid(string Email)
        {
            int UserId = 0;
            var hel = context.UserDetails.Where(i => i.Email == Email).FirstOrDefault();
            if (hel.Email == Email)
            {
                UserId = hel.UserId;
            }
            return UserId;
        }

        /*public Skills GetSkillName(int SkillId )
        {
            return context.Skills.Where(i => i.SkillId == SkillId ).First();
        }*/

    }
}
