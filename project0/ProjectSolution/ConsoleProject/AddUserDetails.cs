//using ProjectLibrary;
using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ConsoleProject
{
    public class AddUserDetails:IMenu
    {
        private static UserDetails userDetails = new UserDetails();
        // reading connection String from a file
        private static string conStr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");

        SqlRepo RRR = new SqlRepo(conStr);
        //private static UserDetails newUser = new UserDetails();
         IFile repo = new SqlRepo(conStr);

        public void Display()
        {
            Console.WriteLine("Enter User information");          
            Console.WriteLine("[2] userId - " + userDetails.userId); 
            Console.WriteLine("[3] Age - " + userDetails.Age);
            Console.WriteLine("[4] Salutation - " + userDetails.Salutation);
            Console.WriteLine("[5] FirstName - " + userDetails.FirstName);
            Console.WriteLine("[6] MiddleName - " + userDetails.MiddleName);
            Console.WriteLine("[7] LastName - " + userDetails.LastName);
            Console.WriteLine("[8] Gender - " + userDetails.Gender);         
            Console.WriteLine("[9] Email - " + userDetails.Email);
            Console.WriteLine("[10] Password - " + userDetails.Password);
            // Console.WriteLine("[2] GetUserDetails - ");
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
                        Log.Information("Adding UserDetails \n" + userDetails);
                        RRR.Add(userDetails);
                        Log.Information("Successful at adding  UserDetails!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Information($"Failed to add UserDetails -{exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        // RRR.Add(userDetails);
                    }
                    return "SignUp"; // return "any other pages"
               // case"2":
                 //   RRR.GetAllDetails();
                //    return "Menu";
                case "2":
                    Console.WriteLine("Please enter an userId!");
                    userDetails.userId = Convert.ToInt32(Console.ReadLine());
                    return "AddUserDetails";
                case "3":
                    Console.WriteLine("Please enter a Age!");
                    userDetails.Age = Convert.ToInt32(Console.ReadLine());
                    return "AddUserDetails";
                case "4":
                    Console.WriteLine("Please enter the Salutation!");
                    userDetails.Salutation = Console.ReadLine();
                    return "AddUserDetails";
                case "5":
                    Console.WriteLine("Please enter the FirstName");
                    userDetails.FirstName = Console.ReadLine();
                    return "AddUserDetails";
                case "6":
                    Console.WriteLine("Please enter the MiddleName");
                    userDetails.MiddleName = Console.ReadLine();
                    return "AddUserDetails";
                case "7":
                    Console.WriteLine("Please enter the LastName");
                    userDetails.LastName = Console.ReadLine();
                    return "AddUserDetails";
                case "8":
                    Console.WriteLine("Please enter the Gender");
                    userDetails.Gender = Console.ReadLine();
                    return "AddUserDetails";
                case "9":
                    Console.WriteLine("Please enter the Email");
                    userDetails.Email = Console.ReadLine();
                    return "AddUserDetails";
                case "10":
                    Console.WriteLine("Please enter the Password");
                    userDetails.Password = Console.ReadLine();
                    return "AddUserDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddUserDetails";
            }
        }
    }
}
