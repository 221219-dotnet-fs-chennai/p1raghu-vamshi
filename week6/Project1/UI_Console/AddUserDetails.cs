/*using BusinessLogic;
using Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Console
{
    public class AddUserDetails:IClass
    {
        private static UserDetails userDetails = new UserDetails();
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");

        ILogic repo = new Logic();
         public void Display()
        {
            Console.WriteLine("Enter User Details!");
            Console.WriteLine(" [10] Password      - "   + userDetails.Password);
            Console.WriteLine(" [9]  Email         - "   + userDetails.Email);
            Console.WriteLine(" [8]  Gender        - "   + userDetails.Gender);
            Console.WriteLine(" [7]  LastName      - "   + userDetails.LastName);
            Console.WriteLine(" [6]  MiddleName    - "   + userDetails.MiddleName);
            Console.WriteLine(" [5]  FirstName     - "   + userDetails.FirstName);
            Console.WriteLine(" [4]  Salutation    - "   + userDetails.Salutation);
            Console.WriteLine(" [3]  Age           - "   + userDetails.Age);
            Console.WriteLine(" [2]  userId        - "   + userDetails.userId);
            Console.WriteLine(" [1]  Save");
            Console.WriteLine(" [0]  GoBack");


        }
         public string UserChoice()
        {
            string userInput = Console.ReadLine();
             switch(userInput)
            {
                case "0":
                    return "Class";
                case "1":
                    return "Class";
                case "2":
                    Console.WriteLine("Please enter userId");
                    //  userDetails.userId = Console.ReadLine();
                    return "AddUserDetails";
                case "3":
                    Console.WriteLine("Please enter a age");
                    return "AddUserDetails";
                case "4":
                    Console.WriteLine("Please enter Salutation");
                    return "AddUserDetails";
                case "5":
                    Console.WriteLine("Please enter FirstName");
                    return "AddUserDetails";
                case "6":
                    Console.WriteLine("Please enter a MiddleName");
                    return "AddUserDetails";
                case "7":
                    Console.WriteLine("Please enter a lastName");
                    return "AddUserDetails";
                case "8":
                    Console.WriteLine("Please enter a Gender");
                    return "AddUserDetails"; ;
                case "9":
                    Console.WriteLine("Please enter a Email");
                    return "AddUserDetails";
                case "10":
                    Console.WriteLine("Please enter a Password");
                    return "AddUserDetails";
                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please enter to continue");
                    Console.ReadLine();
                    return "AddUserDetails";
            }
        }
    }
}
*/