using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class LoginUp:IMenu
    {
        public void Display()
        {
            Console.WriteLine(" Login Successful !");
            //  Console.WriteLine("What would like to do ?");
            Console.WriteLine("[7] - Delete");
            Console.WriteLine("[6] - Getting All User Details");
            Console.WriteLine("[5] - Show SkillsDetails");
            Console.WriteLine("[4] - Show EducationDetails");
            Console.WriteLine("[3] - Show CompanyDetails");
            Console.WriteLine("[2] - Show AddressDetails");
            Console.WriteLine("[1] - Show UserDetails");
            Console.WriteLine("[0] - Go Back");
        }
        public string UserChoice()
        {
            Console.Write(" \n Enter your Choice");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
               case "0":
                    return "Menu";
               case "1":
                    return "GetUserDetails";

               case "2":
                    return "GetAddressDetails";
               case "3":
                    return "GetCompanyDetails";
               case "4":
                    return "GetEducationDetails";
               case "5":
                    return "GetSkillsDetails";
               case "6":
                    return "GettingTranierDetails";
               case "7":
                    return "Delete";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Menu";
            }
        }
    }
}
