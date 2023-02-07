/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Console
{
    public class Class:IClass
    {
       public void Display()
        {
            Console.WriteLine("Welcome to UserDetails!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[2]  Get for UserDetails ");
            Console.WriteLine("[1] Add a new UserDetails");
            Console.WriteLine("[0] Exit");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            //Switch cases are just useful if you are doing a bunch of comparison
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddUserDetails";
                case "2":
                    return "GetUserDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Class";
            }
        }

    }
}
*/