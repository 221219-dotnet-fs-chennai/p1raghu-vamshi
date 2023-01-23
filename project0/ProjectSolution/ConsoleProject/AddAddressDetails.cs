using ProjestLibrary;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class AddAddressDetails:IMenu
    {
        private static Address address = new Address();
        // reading connection String from a file
        private static string conStr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        SqlRepo RRR = new SqlRepo(conStr);       
        IFile repo = new SqlRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter user information");
            Console.WriteLine("[2] userId - " + address.userId);
            Console.WriteLine("[3] userAddress - " + address.userAddress);
            Console.WriteLine("[4] country - " + address.country);
            Console.WriteLine("[5] pincode - " + address.pincode);
           // Console.WriteLine("[2] GetAddressDetails - ");
            Console.WriteLine("[1] Save");
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
                    try
                    {
                        Log.Information("Adding Address \n" + address);
                        RRR.Add(address);
                        Log.Information("Successful at adding  Address!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Information($"Failed to add Address -{exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        // RRR.Add(address);
                    }
                  //  RRR.Add(address);
                    return "SignUp"; // "AddAddressDetails"; // return "any other pages"
               // case "2":
                 //   RRR.GetDetails();
                 //   return "Menu";
                case "2":
                    Console.WriteLine("Please enter an userId!");
                    address.userId = Convert.ToInt32(Console.ReadLine());
                    return "AddAddressDetails";
                case "3":
                    Console.WriteLine("Please enter the userAddress!");
                    address.userAddress = Console.ReadLine();
                    return "AddAddressDetails";
                case "4":
                    Console.WriteLine("Please enter the country!");
                    address.country = Console.ReadLine();
                    return "AddAddressDetails";
                case "5":
                    Console.WriteLine("Please enter an pincode!");
                    address.pincode = Convert.ToInt32(Console.ReadLine());
                    return "AddAddressDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddAddressDetails";
            }
        }
    }
}
