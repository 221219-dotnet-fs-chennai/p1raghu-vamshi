using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class GetUserDetails:IMenu
    {
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        public string email = Validate.Login();
        IFile repo = new SqlRepo(constr);
        private IEnumerable<object> listofDetails;
        //public object listofDetails { get; private set; }
        public void Display()
        {
            Console.WriteLine("please select an option to filter the UserDetails database");
            Console.WriteLine("[3] Delete User Details");
            Console.WriteLine("[2]  UpdateDetails");
            Console.WriteLine("[1] View UserDetails");
            Console.WriteLine("[0] Go back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Menu";
                case "1":
                    //logic to Display the result
                    Log.Information("Getting All UserDetails");
                    var listofDetails = repo.GetSpecificDetails(email);
                    Log.Information($"Got list of {listofDetails.Count} UserDetails");
                    Log.Information("Reading userDetails about to start");
                    foreach (var r in listofDetails)
                    {
                        Console.WriteLine("================");
                        Console.WriteLine(r.ToString());
                    }
                    Log.Information("Reading userDetails ends");
                    Console.WriteLine("please press enter to continue");
                    Console.ReadLine();
                    return "LoginUp";
                    case "2":
                    return "GetUserDetails";
                    case "3":
                    return "DeleteUserDetails";
                default:
                    Console.WriteLine("please input a valid response");
                    Console.WriteLine("please press enter to continue");
                    Console.ReadLine();
                    return "GetUserDetails";

            }
        }
    }
}
