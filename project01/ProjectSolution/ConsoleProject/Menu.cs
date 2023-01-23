using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class Menu:IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the user");
            Console.WriteLine("what would like to do");
            Console.WriteLine("  ");
            Console.WriteLine("Press[0]        --          Exit");
            Console.WriteLine("  ");
           /* Console.WriteLine("Press [1]      --           SignUp");
            Console.WriteLine("  ");
            Console.WriteLine("Press [2]      --           Login");*/         
            Console.WriteLine("Press[1]        --          AddLoginDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[2]        --          GetLoginDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[3]        --          Add a new user");
            Console.WriteLine("  ");
            Console.WriteLine("Press[4]        --          Get all details");
            Console.WriteLine("  ");
            Console.WriteLine("Press[5]        --          AddEducationDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[6]        --          GetEducationDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[5]        --          AddEducationDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[6]        --          GetEducationDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[7]        --          AddCompanyDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[8]        --          GetCompanyDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[9]        --          AddAddressDetails");
            Console.WriteLine("  ");
            Console.WriteLine("Press[10]       --          GetAddressDetails"); 
        }
        public string UserChoice()
        {
            string userInput =
                Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "Exit";
              /* case "1":
                  return ("SignUp");
               case "2":
                    return ("Login");*/               
                case "1":
                    return "AddLoginDetails";
                case "2":
                    return "GetLoginDetails";
                case "3":
                    return "AddUserDetails";
                case "4":
                    return "GetUserDetails";
                case "5":
                    return "AddEducationDetails";
                    case "6":
                    return "GetEducationDetails";
                case "7":
                    return "AddCompanyDetails";
                case "8":
                    return "GetCompanyDetails";
                case "9":
                    return "AddAddressDetails";
                case "10":
                    return "GetAddressDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Menu";
            }
        }
    }
}
