using ProjectLibrary;
using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class AddLoginDetails : IMenu
    {

        private static Login login = new Login();
        // reading connection String from a file
        private static string conStr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");

        SqlRepo RRR = new SqlRepo(conStr);
        //private static UserDetails newUser = new UserDetails();  "C:\AssociatesLink\Azurelink.txt"
        IFile repo = new SqlRepo(conStr);

        public void Display()
        {
            Console.WriteLine("Enter Jaciechan information");
            Console.WriteLine("[5] userId - " + login.userId);
            Console.WriteLine("[4] Email - " + login.Email);
            //Console.WriteLine("[7] Phone - " + newRestaurant.Phone);
            Console.WriteLine("[3] Password - " + login.Password);
            Console.WriteLine("[2] GetLoginDetails - ");
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
                        Log.Information("Adding Login \n" + login);
                        RRR.Add(login);
                        Log.Information("Successful at adding  Login!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Information($"Failed to add Login -{exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        // RRR.Add(userDetails);
                    }
                    RRR.Add(login);
                    return "GetAllDetails"; // "AddLoginDetails"; // return "any other pages"
                case "2":
                    RRR.GetDetails();
                    return "Menu";
                case "5":
                    Console.WriteLine("Please enter an userId!");
                    login.userId = Convert.ToInt32(Console.ReadLine());
                    return "AddLoginDetails";
                case "4":
                    Console.WriteLine("Please enter the Email!");
                    login.Email = Console.ReadLine();
                    return "AddLoginDetails";
                case "3":
                    Console.WriteLine("Please enter the Password!");
                    login.Password = Console.ReadLine();
                    return "AddLoginDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddLoginDetails";
            }
        }
    }
}
