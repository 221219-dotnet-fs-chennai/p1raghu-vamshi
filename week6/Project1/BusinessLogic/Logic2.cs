using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityApi;
using Modules;
using da = EntityApi;
using EntityApi.Entities;
using System.Numerics;

namespace BusinessLogic
{
    public class Logic2:ILogic2
    {
        da.AddressSqlRepo repo = new da.AddressSqlRepo();
        public da.Entities.Address AddAddress(Modules.Address adu)
        {
            return repo.Add(Mapper.Map(adu));
        }
        public IEnumerable<Modules.Address> GetAddress()
        {
            return Mapper.Map(repo.GetAddress());
        }
        public Modules.Address RemoveAddress(long r)

        {
            var deletedAddress = repo.RemoveAddress(r);
            if (deletedAddress != null)
                return Mapper.Map(deletedAddress);

            else
                return null;
        }
        public Modules.Address UpdateAddress(long PhoneNumber, Modules.Address r)
        {
            var address = (from rst in repo.GetAddress()
                             where rst.PhoneNumber == r.PhoneNumber
                             select rst).FirstOrDefault();
            if (address != null)
            {
                address.UserId = r.userId;
                address.PhoneNumber = r.PhoneNumber;
                address.UserAddress = r.userAddress;
                address.Country = r.country;
                address.Pincode = r.pincode;
               


                address = repo.UpdateAddress(address);
            }
            return Mapper.Map(address );
        }

        
    }
}
