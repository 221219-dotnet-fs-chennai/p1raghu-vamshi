using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da = EntityApi.Entities;
using Modules;

namespace BusinessLogic
{
    public interface ICompanyLogic
    {
        public da.Company AddCompany(Modules.Company company);
        IEnumerable<Modules.Company> GetCompany();

        //UserDetail AddUserDetails(UserDetail r);
        Company RemoveCompany(string r);
        Company UpdateCompany(string CompanyEmail, Company r);
    }
}
