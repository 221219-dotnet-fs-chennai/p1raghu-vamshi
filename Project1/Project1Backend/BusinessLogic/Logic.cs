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
        TValidation val = new TValidation();
        Validate _id;
        da.IRepo<da.Entities.UserDetail> repo;

        public Logic(Validate id, da.IRepo<da.Entities.UserDetail>  _repo)
        {
            _id = id;
            repo = _repo;
        }
        public Modules.UserDetails AddUserDetails(Modules.UserDetails user)
        {
            user.Email = val.IsValidEmail(user.Email) ? user.Email : throw new("Invalid email format");
            user.Password = val.IsValidPassword(user.Password) ? user.Password : throw new("enter Password of length 8-20 with at lest 1 Uppercase Letter,1 number");
            user.Gender = val.IsValidGender(user.Gender) ? user.Gender : throw new("Enter Male/Female");
           // user.userId = _id.Pid(Email);
            return Mapper.Map(repo.Add(Mapper.Map(user)));
        }

     
        public IEnumerable<Modules.UserDetails> GetUserDetails()
        {
            return Mapper.Map(repo.GetUserDetails());
        }
        public IEnumerable< Modules.UserDetails> Get(string Email)
        {
            int UserId = _id.Pid(Email);
            return Mapper.Map(repo.Get(UserId));
        }
        public UserDetails RemoveUserDetailsByUserId(string Email)

        {
            int id = _id.Pid(Email);
            return Mapper.Map(repo.RemoveUserDetails(id));
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
