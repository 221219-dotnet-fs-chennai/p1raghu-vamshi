using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityApi;
using Modules;
using da = EntityApi;
using EntityApi.Entities;
using System.Security.Cryptography;

namespace BusinessLogic
{
    public class Logic1 : ILogic1
    {
        Validate _id;
        da.IEducationRepo<da.Entities.Education> repo;

        public Logic1(Validate id, da.IEducationRepo<da.Entities.Education> _repo)
        {
            _id= id;
            repo = _repo;
        }
        public Modules.Education AddEduDetails(string Email,Modules.Education edu)
        {
            edu.userId =_id.Pid(Email);
            return Mapper.Map(repo.Add(Mapper.Map(edu)));
        }
        public IEnumerable<Modules.Education> GetEducationDetails()
        {
            return Mapper.Map(repo.GetEducationDetails());
        }
        public IEnumerable<Modules.Education> Get(string email)
        {
            int UserId =  _id.Pid(email);
            return Mapper.Map(repo.Get(UserId));
        }


        public Modules.Education RemoveEducation(string r)

        {
            int id = _id.Pid(r);
            return Mapper.Map(repo.RemoveEducation(id));
        }

        

        public da.Entities.Education UpdateEducationDetails(string Email, Modules.Education r)
        {
            var education = (from rst in repo.GetEducationDetails()
                               where rst.UserId == r.userId
                               select rst).FirstOrDefault();
            if (education != null)
            {
                education.UserId = r.userId;
                education.RollNo = r.RollNo;
                education.University = r.University;
                education.UG = r.UG;
                education.Specialization = r.Specialization;
                education.PassedOutYear = r.PassedOutYear;
                education.Grade = r.Grade;
                

                education = repo.UpdateEducationDetails(education);
            }
            return repo.UpdateEducationDetails(education);
        }

    }
}
