using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityApi;
using Modules;
using da = EntityApi;
using EntityApi.Entities;

namespace BusinessLogic
{
    public class Logic1:ILogic1
    {
        da.EducationSqlRepo repo= new da.EducationSqlRepo();
        public da.Entities.Education AddEduDetails(Modules.Education edu)
        {
            return repo.Add(Mapper.Map(edu));
        }
        public IEnumerable<Modules.Education> GetEducationDetails()
        {
            return Mapper.Map(repo.GetEducationDetails());
        }

      

        public Modules.Education RemoveEducation(int r)

        {
            var deletedEducation = repo.RemoveEducation(r);
            if (deletedEducation != null)
                return Mapper.Map(deletedEducation);
            
            else
                return null;
        }

        

        public Modules.Education UpdateEducationDetails(int RollNo, Modules.Education r)
        {
            var education = (from rst in repo.GetEducationDetails()
                               where rst.RollNo == r.RollNo
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
            return Mapper.Map(education);
        }
    }
}
