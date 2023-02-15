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
        Validate _id;
        da.ICompanyRepo<da.Entities.Company> repo;

        public CompanyLogic(Validate id, da.CompanySqlRepo _repo)
        {
            _id = id;
            repo = repo;
        }
        public Modules.Company AddCompany(string email,Modules.Company user)
        {
            user.userId = _id.Pid(email);
            return Mapper.Map(repo.Add(Mapper.Map(user)));
        }
        public IEnumerable<Modules.Company> GetCompany()
        {
            return Mapper.Map(repo.GetCompany());
        }
        public IEnumerable<Modules.Company> Get(string email)
        {
            int userId = _id.Pid(email);
            return Mapper.Map(repo.Get(userId));
        }
        public Modules.Company RemoveCompany(string email)

        {
            int id = _id.Pid(email);
            return Mapper.Map(repo.RemoveCompany(id));
        }
        public Modules.Company UpdateCompany(string Email, Modules.Company r)
        {
            var company = (from rst in repo.GetCompany()
                               where rst.UserId == r.userId
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
