using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjestLibrary
{
    public interface IFile
    {
        
            UserDetails Add(UserDetails userDetails);
            List<UserDetails> GetAllDetails();
        List<UserDetails> GetSpecificDetails(string email);
     //   List<Login> GetDetails();
        List<Company> GetComDetails();
        List<Education> GetEduDetails();
        List<Skills> GetSkillDetails();
        List<Address> GetAddDetails();

    }
}
