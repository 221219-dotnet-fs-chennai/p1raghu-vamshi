using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da = EntityApi.Entities;
using Modules;

namespace BusinessLogic
{
    public interface ISkillLogic
    {
        Modules.Skills AddSkills(string Email,Modules.Skills skills);
        IEnumerable<Modules.Skills> GetSkills();
        IEnumerable<Modules.Skills> Get(string email);

        //UserDetail AddUserDetails(UserDetail r);
        Modules.Skills RemoveSkills(string r);
       Modules.Skills UpdateSkills(string Email, Modules.Skills r);
    }
}
