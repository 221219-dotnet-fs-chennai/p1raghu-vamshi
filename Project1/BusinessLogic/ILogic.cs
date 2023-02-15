using da=EntityApi.Entities;
using Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface ILogic
    {

         Modules.UserDetails AddUserDetails(string Email,Modules.UserDetails userDetails);
        IEnumerable<Modules.UserDetails> GetUserDetails();

        //UserDetail AddUserDetails(UserDetail r);
       Modules. UserDetails RemoveUserDetailsByUserId(string Email);
        UserDetails UpdateUserDetails(string Email, UserDetails r);
        Modules.UserDetails Get(string Email);
    }
}
