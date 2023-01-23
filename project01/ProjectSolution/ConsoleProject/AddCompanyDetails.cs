using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class AddCompanyDetails:IMenu
    {
        private static Company company = new Company();
        // reading connection String from a file
        private static string conStr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");

        SqlRepo RRR = new SqlRepo(conStr);
        //private static UserDetails newUser = new UserDetails();
        IFile repo = new SqlRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter Jaciechan information");
            Console.WriteLine("[8] userId - " + company.userId);
            Console.WriteLine("[7] CompanyName - " + company.CompanyName);            
            Console.WriteLine("[6] CompanyLocation - " + company.CompanyLocation);
            Console.WriteLine("[5] Experience - " + company.Experience);
            Console.WriteLine("[4] CompanyEmail - " + company.CompanyEmail);
            Console.WriteLine("[3] Website - " + company.Website);
            Console.WriteLine("[2] GetCompanyDetails - ");
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
                        Log.Information("Adding Company \n" + company);
                        RRR.Add(company);
                        Log.Information("Successful at adding  Company!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Information($"Failed to add Company -{exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        // RRR.Add(userDetails);
                    }
                    RRR.Add(company);
                    return "GetAllDetails"; // "AddLoginDetails"; // return "any other pages"
                case "2":
                    RRR.GetComDetails();
                    return "Menu";               
                case "3":
                    Console.WriteLine("Please enter the Website!");
                    company.Website = Console.ReadLine();
                    return "AddCompanyDetails";
                case "4":
                    Console.WriteLine("Please enter the CompanyEmail!");
                    company.CompanyEmail = Console.ReadLine();
                    return "AddCompanyDetails";
                case "5":
                    Console.WriteLine("Please enter the Experience!");
                    company.Experience = Convert.ToInt32(Console.ReadLine());
                    return "AddCompanyDetails";
                case "6":
                    Console.WriteLine("Please enter the CompanyLocation!");
                    company.CompanyLocation = Console.ReadLine();
                    return "AddCompanyDetails";
                case "7":
                    Console.WriteLine("Please enter the CompanyName!");
                    company.CompanyName = Console.ReadLine();
                    return "AddCompanyDetails";
                case "8":
                    Console.WriteLine("Please enter an userId!");
                    company.userId = Convert.ToInt32(Console.ReadLine());
                    return "AddCompanyDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddCompanyDetails";
            }
        }
    }
}
