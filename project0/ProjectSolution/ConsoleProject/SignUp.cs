using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{

    public class SignUp :IMenu
    {
         public void Display()
        {
            Console.WriteLine("Welcome to the UserDetails !");
            Console.WriteLine("What would like to do ?");
            Console.WriteLine("[5] AddSkillsDetails");
            Console.WriteLine("[4] AddEducationDetails");
            Console.WriteLine("[3] AddCompanyDetails");
            Console.WriteLine("[2] AddAddressDetails");
            Console.WriteLine("[1] Add a new User");
            Console.WriteLine("[0] Go Back");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Menu";
                case "1":
                    return "AddUserDetails";
                   
                case "2":
                    return "AddAddressDetails";
                case "3":
                    return "AddCompanyDetails";
                case "4":
                     return "AddEducationDetails";
                case "5":
                  
                    return "AddSkillsDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Profile";
            }
        }
    }
}
