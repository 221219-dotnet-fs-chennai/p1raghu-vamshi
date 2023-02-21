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
using System.Security.Cryptography;

namespace BusinessLogic
{
    public class Logic2:ILogic2
    {
        Validate _id;
        da.IAddressRepo<da.Entities.Address> repo;

        public Logic2(Validate id, da.IAddressRepo<da.Entities.Address> _repo)
        {
            _id = id;
            repo = _repo;
        }
        public Modules.Address AddAddress(Modules.Address adu)
        {
            //adu.userId = _id.Pid(Email);
            return Mapper.Map(repo.Add(Mapper.Map(adu)));
        }
        public IEnumerable<Modules.Address> GetAddress()
        {
            return Mapper.Map(repo.GetAddress());
        }
        public IEnumerable<Modules.Address> Get(string email)
        {
            int UserId = _id.Pid(email);
            return Mapper.Map(repo.Get(UserId));
        }
        public Modules.Address RemoveAddress(string email)

        {
            //var deletedAddress = repo.RemoveAddress(email);
            int id = _id.Pid(email);
            return Mapper.Map(repo.RemoveAddress(id));
        }
        public Modules.Address UpdateAddress(string Email, Modules.Address r)
        {
            var address = (from rst in repo.GetAddress()
                             where rst.UserId == r.userId
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
            return Mapper.Map(address);
        }        
    }
}
