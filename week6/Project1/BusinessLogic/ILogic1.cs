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
        public da.Education AddEduDetails(Education education);
        IEnumerable<Modules.Education> GetEducationDetails();

        //UserDetail AddUserDetails(UserDetail r);
       Education RemoveEducation(int r);
       Education UpdateEducationDetails(int RollNo, Education r);
    }
}
