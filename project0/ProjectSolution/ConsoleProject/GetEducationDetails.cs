using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjestLibrary;

namespace ConsoleProject
{
    public class GetEducationDetails:IMenu
    {
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");

        IFile repo = new SqlRepo(constr);
        //private IEnumerable<object> listofDetails;
        //public object listofDetails { get; private set; }
        public void Display()
        {
            Console.WriteLine("please select an option to filter the Education database");
            Console.WriteLine("[2]  UpdateEducation");
            Console.WriteLine("[1] view EducationDetails");
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
                    Log.Information("Getting All EducationDetails");
                    var listofDetails = repo.GetEduDetails();
                    // Log.Information($"Got list of {listofDetails.Count} Login");
                    Log.Information("Reading education about to start");
                    foreach (var r in listofDetails)
                    {
                        Console.WriteLine("================");
                        Console.WriteLine(r.ToString());
                    }
                    Log.Information("Reading education ends");
                    Console.WriteLine("please press enter to continue");
                    Console.ReadLine();
                    return "LoginUp";
                    case "2":
                    return "UpdateEducation";
                default:
                    Console.WriteLine("please input a valid response");
                    Console.WriteLine("please press enter to continue");
                    Console.ReadLine();
                    return "GetEducationDetails";

            }
        }
    }
}
