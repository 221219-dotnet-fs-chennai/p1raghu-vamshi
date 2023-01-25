using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class DeleteSkillDetails:IMenu
    {
        static Skills skills = new Skills();
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        IFile repo = new SqlRepo(constr);
        int pid = Validate.Pid();
        public void Display()
        {
            //  skills = repo.GetSkillDetails();
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------");
            System.Console.WriteLine("****************************************** Delete Skills **************************************");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
            System.Console.WriteLine("[1] To Delete SkillName        - " + skills.SkillName);
            System.Console.WriteLine("[2] save");
            System.Console.WriteLine("[3] Go Back");

        }
        public string UserChoice()
        {
            string userInput = System.Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    System.Console.WriteLine("Please enter To Delete SkillName!");
                    skills.SkillName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($" Delete From Raghu.Skills where SkillName = @SkillName and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@SkillName", skills.SkillName);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteSkillDetails";
                case "2":
                    /*try
                    {
                        Log.Information("Adding record \n" + newskills);
                        repo.Add(newskills);
                        Log.Information("Successful at adding Record!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Error($"Failed to add Record - {exc.Message}");
                        System.Console.WriteLine(exc.Message);
                        System.Console.WriteLine("Please press Enter to continue");
                        System.Console.ReadLine();
                    }*/
                    System.Console.WriteLine("saved successfully");
                    System.Console.ReadKey();
                    return "DeleteSkillDetails";
                case "3":
                    return "GetSkillDetails";
                default:
                    System.Console.WriteLine("Please input a valid response");
                    System.Console.WriteLine("Please press Enter to continue");
                    System.Console.ReadLine();
                    return "DeleteSkillDetails";
            }
        }
    }
}
