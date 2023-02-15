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
    public class CompanySqlRepo:ICompanyRepo<Entities.Company>
    {
        public CompanySqlRepo() { }
        Entities.AssociatesDbContext context = new Entities.AssociatesDbContext();
        public Entities.Company Add(Entities.Company company)
        {
            context.Add(company);
            context.SaveChanges();
            return company;
        }
        public List<Entities.Company> GetCompany()
        {
            return context.Company.ToList();
        }
        public IEnumerable<Entities.Company> Get(int id)
        {
            var _id = context.Company.Where(i => i.UserId == id);
            return _id;
        }
        public Entities.Company RemoveCompany(int UserId)
        {
            var id = context.Company.Where(t => t.UserId == UserId).FirstOrDefault();
           // if (search != null)
            
                context.Company.Remove(id);// this will generate DELETE query of Sql to be passed to Database
                context.SaveChanges();
            
            return id;

        }
        public Entities.Company UpdateCompany(Entities.Company t)
        {
            context.Company.Update(t);// this will generate UPDATE sql query to be passed to databse via ADO.Net
            context.SaveChanges();
            return t;
        }
    }
}
