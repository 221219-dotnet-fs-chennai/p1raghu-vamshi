using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class Menu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the user");
            Console.WriteLine();
            Console.WriteLine("what would like to do");
            Console.WriteLine();
            Console.WriteLine("Press[0]        --          Exit");
            Console.WriteLine("  ");
            Console.WriteLine("Press [1]      --           SignUp");
            Console.WriteLine("  ");
            Console.WriteLine("Press [2]      --           Login");
          
         }
          public  string UserChoice()
            { 

            string userInput = Console.ReadLine();
               
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "SignUp";
                case "2":
                    return "Validate";
                    case "3":
                    return "LoginUp";
              
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Menu";
            }

        }
    }
}
