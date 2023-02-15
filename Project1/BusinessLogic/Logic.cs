using EntityApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da = EntityApi;
using Modules;
using EntityApi.Entities;

namespace BusinessLogic
{
    public class Logic : ILogic
    {
        Validate _id;
        da.IRepo<da.Entities.UserDetail> repo;

        public Logic(Validate id, da.SqlRepo _repo)
        {
            _id = id;
            repo = _repo;
        }
        public Modules.UserDetails AddUserDetails(string Email,Modules.UserDetails user)
        {
            user.userId = _id.Pid(Email);
            return Mapper.Map(repo.Add(Mapper.Map(user)));
        }

     
        public IEnumerable<Modules.UserDetails> GetUserDetails()
        {
            return Mapper.Map(repo.GetUserDetails());
        }
        public Modules.UserDetails Get(string Email)
        {
            return Mapper.Map(repo.Get(Email));
        }
        public UserDetails RemoveUserDetailsByUserId(string Email)

        {
            var deletedUserDetails = repo.RemoveUserDetails(Email);
            if (deletedUserDetails != null)
                return Mapper.Map(deletedUserDetails);
            else
                return null;
        }
        public UserDetails UpdateUserDetails(string Email, UserDetails r)
        {
            var userDetails = (from rst in repo.GetUserDetails()
                               where rst.UserId == r.userId
                               select rst).FirstOrDefault();
            if (userDetails != null)
            {
                userDetails.UserId = r.userId;
                userDetails.Age = r.Age;
                userDetails.Salutation = r.Salutation;
                userDetails.FirstName = r.FirstName;
                userDetails.MiddleName = r.MiddleName;
                userDetails.LastName = r.LastName;
                userDetails.Gender = r.Gender;
                userDetails.Email = r.Email;
                userDetails.Password = r.Password;

                userDetails = repo.UpdateUserDetails(userDetails);
            }
            return Mapper.Map(userDetails);
        }
    }
}
