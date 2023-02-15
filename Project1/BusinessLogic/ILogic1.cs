using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da = EntityApi.Entities;
using Modules;

namespace BusinessLogic
{
   public interface ILogic1
    {
        Modules.Education AddEduDetails(string Email , Modules.Education education);
        IEnumerable<Modules.Education> GetEducationDetails();
        IEnumerable<Modules.Education> Get(string email);

        //UserDetail AddUserDetails(UserDetail r);
       Modules. Education RemoveEducation(string Email);
       da.Education UpdateEducationDetails(string Email, Modules.Education r);
    }
}
