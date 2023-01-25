using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class GetCompanyDetails:IMenu
    {
       int Id = Validate.Pid();
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");

        IFile repo = new SqlRepo(constr);
        //private IEnumerable<object> listofDetails;
        //public object listofDetails { get; private set; }
        public void Display()
        {
            Console.WriteLine("please select an option to filter the Company database");
            Console.WriteLine("[3] Delete Company Details");
            Console.WriteLine("[2] Update Company Details");
            Console.WriteLine("[1] View CompanyDetails");
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
                    Log.Information("Getting All CompanyDetails");
                    var listofDetails = repo.GetComDetails(Id);
                    // Log.Information($"Got list of {listofDetails.Count} Login");
                    Log.Information("Reading company about to start");
                    foreach (var r in listofDetails)
                    {
                        Console.WriteLine("================");
                        Console.WriteLine(r.ToString());
                    }
                    Log.Information("Reading  ends");
                    Console.WriteLine("please press enter to continue");
                    Console.ReadLine();
                    return "LoginUp";
                case "2":
                    return "UpdateCompany";
                case "3":
                    return "DeleteCompanyDetails";
                default:
                    Console.WriteLine("please input a valid response");
                    Console.WriteLine("please press enter to continue");
                    Console.ReadLine();
                    return "GetDetails";

            }
        }
    }
}
