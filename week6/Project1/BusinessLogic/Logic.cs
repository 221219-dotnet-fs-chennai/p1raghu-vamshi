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
        IRepo<da.Entities.UserDetail> repo;

        private object UserDetail;

        public Logic()
        {
            repo = new da.SqlRepo();
        }
        public  da.Entities.UserDetail AddUserDetails(Modules.UserDetails user)
        {
            return repo.Add(Mapper.Map(user));
        }

        public UserDetail AddUserDetails(UserDetail r)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modules.UserDetails> GetUserDetails()
        {
            return Mapper.Map(repo.GetAll());
        }
        public UserDetails RemoveUserDetailsByUserId(int r)

        {
            var deletedUserDetails = repo.RemoveUserDetails(r);
            if (deletedUserDetails != null)
                return Mapper.Map(deletedUserDetails);
            else
                return null;
        }
        public UserDetails UpdateUserDetails(int UserId, UserDetails r)
        {
            var userDetails  = (from rst in repo.GetAll()
                              where  rst.UserId == r.userId
                              select rst).FirstOrDefault();
            if (UserDetail != null)
            {
                userDetails.UserId = r.userId;
                userDetails.Age = r.Age;
                userDetails.Salutation = r.Salutation;
                userDetails.FirstName = r.FirstName;
                userDetails.MiddleName= r.MiddleName;
                userDetails.LastName = r.LastName;
                userDetails.Gender= r.Gender;
                userDetails.Email = r.Email;
                userDetails.Password=r.Password;

                userDetails = repo.UpdateUserDetails(userDetails);
            }
             return Mapper.Map(userDetails);
        }

        public UserDetail UpdateUserDetails(int UserId, UserDetail r)
        {
            throw new NotImplementedException();
        }

        UserDetails ILogic.RemoveUserDetailsByUserId(int r)
        {
            throw new NotImplementedException();
        }
    }
}
