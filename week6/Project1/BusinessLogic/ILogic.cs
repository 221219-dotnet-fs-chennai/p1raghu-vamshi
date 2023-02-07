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

        public da.UserDetail AddUserDetails(Modules.UserDetails userDetails);
        IEnumerable<Modules.UserDetails> GetUserDetails();

        //UserDetail AddUserDetails(UserDetail r);
        UserDetails RemoveUserDetailsByUserId(int r);
        UserDetails UpdateUserDetails(int UserId, UserDetails r);
        // object GetUserDetailsByUserId(int userId);
        // object GetAll();
        //  UserDetails UpdateUserDetails(string name, UserDetails r);
    }
}
