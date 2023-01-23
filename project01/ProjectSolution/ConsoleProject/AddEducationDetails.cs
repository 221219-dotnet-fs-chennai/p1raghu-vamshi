using ProjestLibrary;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class AddEducationDetails:IMenu
    {
        private static Education education = new Education();
        // reading connection String from a file
        private static string conStr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");

        SqlRepo RRR = new SqlRepo(conStr);
        //private static UserDetails newUser = new UserDetails();
        IFile repo = new SqlRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter Jaciechan information");
            Console.WriteLine("[8] userId - " + education.userId);
            Console.WriteLine("[7] University - " + education.University);
            //Console.WriteLine("[7] Phone - " + newRestaurant.Phone);
            Console.WriteLine("[6] UG - " + education.UG);
            Console.WriteLine("[5] Specialization - " + education.Specialization);
            Console.WriteLine("[4] PassedOutYear - " + education.PassedOutYear);
            Console.WriteLine("[3] grade - " + education.grade);
            Console.WriteLine("[2] GetEducationDetails - ");
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
                        Log.Information("Adding Education \n" + education);
                        RRR.Add(education);
                        Log.Information("Successful at adding  Education!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Information($"Failed to add Education -{exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        // RRR.Add(userDetails);
                    }
                    RRR.Add(education);
                    return "GetAllDetails"; // "AddLoginDetails"; // return "any other pages"
                case "2":
                    RRR.GetEduDetails();
                    return "Menu";
                case "8":
                    Console.WriteLine("Please enter an userId!");
                    education.userId = Convert.ToInt32(Console.ReadLine());
                    return "AddEducationDetails";
                case "7":
                    Console.WriteLine("Please enter the University!");
                    education.University = Console.ReadLine();
                    return "AddEducationDetails";
                case "6":
                    Console.WriteLine("Please enter the UG!");
                    education.UG = Console.ReadLine();
                    return "AddEducationDetails";
                case "5":
                    Console.WriteLine("Please enter the Specialization!");
                    education.Specialization = Console.ReadLine();
                    return "AddEducationDetails";
                case "4":
                    Console.WriteLine("Please enter the PassedOutYear!");
                    education.PassedOutYear = Convert.ToInt32(Console.ReadLine());
                    return "AddEducationDetails";
                case "3":
                    Console.WriteLine("Please enter the grade!");
                    education.grade = Console.ReadLine();
                    return "AddEducationDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddLoginDetails";
            }
        }
    }
}
