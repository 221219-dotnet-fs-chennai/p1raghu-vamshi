using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public interface IRepo<T>
    {
        T Add(T t);
        List<T> GetAll();
        T RemoveUserDetails(int UserId);
        T UpdateUserDetails(T t);


    }
}
