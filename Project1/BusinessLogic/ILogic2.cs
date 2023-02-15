using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da = EntityApi.Entities;
using Modules;
using System.Numerics;

namespace BusinessLogic
{
    public interface ILogic2
    {
        Modules.Address AddAddress(string Email,Modules.Address adu);
        IEnumerable<Modules.Address> GetAddress();
        IEnumerable<Modules.Address> Get(string email);

        //UserDetail AddUserDetails(UserDetail r);
        Modules.Address RemoveAddress(string Email);
        Address UpdateAddress(string Email  , Modules.Address r);
    }
}
