using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityApi
{
   public interface IAddressRepo<A>
    {
        A Add(A t);
        List<A> GetAddress();
        A RemoveAddress(int t);
        A UpdateAddress(A t);
        IEnumerable<A> Get(int t);

    }
}
