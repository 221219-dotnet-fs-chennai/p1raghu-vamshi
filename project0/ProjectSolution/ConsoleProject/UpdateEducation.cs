using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
   public class UpdateEducation:IMenu
    {
        static Education education = new Education();
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        IFile repo = new SqlRepo(constr);
        int pid = Validate.Pid();
        public void Display()
        {
           // education = repo.GetAll(pid);
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------");
            System.Console.WriteLine("****************************************** Update Education ***********************************");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
            System.Console.WriteLine("[1] Update UG                     - " + education.UG);
            System.Console.WriteLine("[2] Update Specialization         - " + education.Specialization);
            System.Console.WriteLine("[3] Update University             - " + education.University);
            System.Console.WriteLine("[4] Update PassedOutYear          - " + education.PassedOutYear);
           // System.Console.WriteLine("[4] Update End year               - " + education.Endyear);
            System.Console.WriteLine("[5] Update grade                  - " + education.grade);
            System.Console.WriteLine("[6] save");
            System.Console.WriteLine("[7] Go Back");

        }

        public string UserChoice()
        {
            string userInput = System.Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    System.Console.WriteLine("Please enter a UG!");
                    string UG = System.Console.ReadLine();
                    education.UG = UG;
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Education SET UG = @UG where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@UG", UG);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateEducation";
                case "2":
                    System.Console.WriteLine("Please enter Specialization!");
                    education.Specialization = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Education SET Specialization = @Specialization where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Specialization", education.Specialization);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateEducation";
                case "3":
                    System.Console.WriteLine("Please enter University!");
                    education.University = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Education SET University = @University where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@University", education.University);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateEducation";
                case "4":
                    System.Console.WriteLine("Please enter New Passed Out Year!");
                    education.PassedOutYear = Convert.ToInt32(System.Console.ReadLine());
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Education SET PassedOutYear = @PassedOutYear where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@PassedOutYear", education.PassedOutYear);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateEducation";     
                case "5":
                    System.Console.WriteLine("Please enter New grade!");
                    education.grade = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Education SET grade = @grade where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@grade", education.grade);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateEducation";
                case "6":
                    /*try
                    {
                        Log.Information("Adding record \n" + newupdate);
                        repo.Add(newupdate);
                        Log.Information("Successful at adding Record!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Error($"Failed to add Record - {exc.Message}");
                        System.Console.WriteLine(exc.Message);
                        System.Console.WriteLine("Please press Enter to continue");
                        System.Console.ReadLine();
                    }
                    System.Console.WriteLine("saved successful");*/
                    System.Console.WriteLine("saved successfully");
                    System.Console.ReadKey();
                    return "UpdateEducation";
                case "7":
                    return "GetEduDetails";
                default:
                    System.Console.WriteLine("Please input a valid response");
                    System.Console.WriteLine("Please press Enter to continue");
                    System.Console.ReadLine();
                    return "UpdateEducation";
            }
        }
    }
}
