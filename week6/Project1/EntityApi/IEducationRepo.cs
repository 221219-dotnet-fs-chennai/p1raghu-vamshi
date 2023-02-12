using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityApi
{
   public interface IEducationRepo<E>
    {
        E Add(E t);
        List<E> GetEducationDetails();
        E RemoveEducation(int RollNo);
        E UpdateEducationDetails(E t);
    }
}
