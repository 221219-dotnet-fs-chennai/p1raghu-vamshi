using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityApi.Entities;
using Microsoft.EntityFrameworkCore;
using Modules;

namespace EntityApi
{
    public class EducationSqlRepo:IEducationRepo<Entities.Education>
    {
        public EducationSqlRepo() { }
        Entities.AssociatesDbContext context= new Entities.AssociatesDbContext();
        public Entities.Education Add(Entities.Education education)
        {
            context.Add(education);
            context.SaveChanges();
            return education;
        }
        public List<Entities.Education> GetEducationDetails() 
        {
            return context.Education.ToList();
        }
        public IEnumerable<Entities.Education> Get(int t)
        {
            var UserId = context.Education.Where(i => i.UserId == t);
            return UserId;
        }

        public Entities.Education RemoveEducation(int UserId)
        {
          var id = context.Education.Where(t => t.UserId == UserId).FirstOrDefault();
          //  if (search != null)
            
                context.Education.Remove(id);// this will generate DELETE query of Sql to be passed to Database
                context.SaveChanges();
            
            return id;

        }

        public Entities.Education UpdateEducationDetails(Entities.Education t)
        {
            context.Education.Update(t);// this will generate UPDATE sql query to be passed to databse via ADO.Net
            context.SaveChanges();
            return t;
        }

        
    }
}
