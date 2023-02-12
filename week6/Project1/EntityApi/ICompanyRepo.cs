using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityApi
{
    public interface ICompanyRepo<C>
    {
        C Add(C t);
        List<C> GetCompany();
        C RemoveCompany(string CompanyEmail);
        C UpdateCompany(C t);
    }
}
