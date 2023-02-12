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
        public da.Address AddAddress(Modules.Address address);
        IEnumerable<Modules.Address> GetAddress();

        //UserDetail AddUserDetails(UserDetail r);
        Address RemoveAddress(long r);
        Address UpdateAddress(long PhoneNumber  , Address r);
    }
}
