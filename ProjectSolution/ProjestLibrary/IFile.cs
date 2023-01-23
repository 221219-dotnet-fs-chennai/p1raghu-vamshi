using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLibrary;

namespace ProjestLibrary
{
    public interface IFile
    {
        
            UserDetails Add(UserDetails userDetails);
            List<UserDetails> GetAllDetails();
            List<Login> GetDetails();
          // List<SignUp> GetDetails();
        List<Education> GetEduDetails();
           List<Company> GetComDetails();
        List<Address> GetAddDetails();
        List<Skills> GetSkillDetails();
    }
}
