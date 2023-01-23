using ProjestLibrary;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class AddSkillsDetails : IMenu
    {
        private static Skills skills = new Skills();
        // reading connection String from a file
        private static string conStr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");

        SqlRepo RRR = new SqlRepo(conStr);
        //private static UserDetails newUser = new UserDetails();
        IFile repo = new SqlRepo(conStr);
        public void Display()
        {
            Console.WriteLine("Enter User information");
            Console.WriteLine("[3] userId - " + skills.userId);
            Console.WriteLine("[2] SkillName - " + skills.SkillName);
            // Console.WriteLine("[2] GetLoginDetails - ");
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
                        Log.Information("Adding Skills \n" + skills);
                        RRR.Add(skills);
                        Log.Information("Successful at adding  Skills!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Information($"Failed to add Login -{exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        // RRR.Add(userDetails);
                    }
                   // RRR.Add(skills);
                    return "SignUp"; // "AddLoginDetails"; // return "any other pages"
               // case "2":
                //    RRR.GetSkillDetails();
                 //   return "Menu";
                case "3":
                    Console.WriteLine("Please enter an userId!");
                    skills.userId = Convert.ToInt32(Console.ReadLine());
                    return "AddSkillsDetails";
                case "2":
                    Console.WriteLine("Please enter the SkillName!");
                    skills.SkillName = Console.ReadLine();
                    return "AddSkillsDetails";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddSkillsDetails";
            }
        }
    }
}
