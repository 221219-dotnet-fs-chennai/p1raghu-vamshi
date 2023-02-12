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
    public class CompanyLogic:ICompanyLogic
    {
        da.CompanySqlRepo repo = new da.CompanySqlRepo();
        public da.Entities.Company AddCompany(Modules.Company user)
        {
            return repo.Add(Mapper.Map(user));
        }
        public IEnumerable<Modules.Company> GetCompany()
        {
            return Mapper.Map(repo.GetCompany());
        }
        public Modules.Company RemoveCompany(string r)

        {
            var deletedCompany = repo.RemoveCompany(r);
            if (deletedCompany != null)
                return Mapper.Map(deletedCompany);
            else
                return null;
        }
        public Modules.Company UpdateCompany(string CompanyEmail, Modules.Company r)
        {
            var company = (from rst in repo.GetCompany()
                               where rst.CompanyEmail == r.CompanyEmail
                               select rst).FirstOrDefault();
            if ( company != null)
            {
                company.UserId = r.userId;
                company.CompanyId = r.CompanyId;
                company.CompanyName = r.CompanyName;
                company.CompanyLocation = r.CompanyLocation;
                company.Experience = r.Experience;
                company.CompanyEmail = r.CompanyEmail;
                company.Website = r.Website;

                company = repo.UpdateCompany( company);
            }
            return Mapper.Map(company);
        }
    }
}
