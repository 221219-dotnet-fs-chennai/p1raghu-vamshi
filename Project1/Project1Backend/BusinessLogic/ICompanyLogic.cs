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
        Modules.Company AddCompany(Modules.Company company);
        IEnumerable<Modules.Company> GetCompany();
        IEnumerable<Modules.Company> Get(string Email);

        //UserDetail AddUserDetails(UserDetail r);
        Modules.Company RemoveCompany(string Email);
        Company UpdateCompany(string Email, Company r);
    }
}
