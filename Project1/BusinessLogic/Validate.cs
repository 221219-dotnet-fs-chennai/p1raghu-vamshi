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

        public int Pid(string email)
        {
            int UserId = 0;
            var res = context.UserDetails.Where(i => i.Email == email).FirstOrDefault();
            if (res.Email == email)
            {
                UserId = res.UserId;
            }
            return UserId;
        }

        /*public Skills GetSkillName(int SkillId )
        {
            return context.Skills.Where(i => i.SkillId == SkillId ).First();
        }*/

    }
}
