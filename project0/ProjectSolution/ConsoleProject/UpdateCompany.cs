using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public  class UpdateCompany:IMenu
    {
        static Company company = new Company();
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        IFile repo = new SqlRepo(constr);
        int pid = Validate.Pid();
        public void Display()
        {
           // company = repo.GetComDetails();
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------");
            System.Console.WriteLine("****************************************** Update Experience **********************************");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
            System.Console.WriteLine("[1] Update Company Name         - " + company.CompanyName);
            System.Console.WriteLine("[2] Update Company Name         - " + company.CompanyName);
            System.Console.WriteLine("[3] Update Experience            - " + company.Experience);
            System.Console.WriteLine("[4] Update Company Email         - " + company.CompanyEmail);
            System.Console.WriteLine("[5] Update Website           - " + company.Website);
            System.Console.WriteLine("[6] save");
            System.Console.WriteLine("[7] Go Back");

        }

        public string UserChoice()
        {
            string userInput = System.Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    System.Console.WriteLine("Please enter  CompanyName!");
                    company.CompanyName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Company SET CompanyName = @CompanyName where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@CompanyName", company.CompanyName);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateCompany";
                case "2":
                    System.Console.WriteLine("Please enter CompanyLocation!");
                    company.CompanyLocation = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Company SET CompanyLocation = @CompanyLocation where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@CompanyLocation", company.CompanyLocation);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateCompany";
                case "3":
                    System.Console.WriteLine("Please enter Experience!");
                    company.Experience = Convert.ToInt32(System.Console.ReadLine());
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Company SET experience = @Experience where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Experience", company.Experience);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateCompany";
                case "4":
                    System.Console.WriteLine("Please enter CompanyEmail !");
                    company.CompanyEmail = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Company SET CompanyEmail = @CompanyEmail where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@CompanyEmail", company.CompanyEmail);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateCompany";
                case "5":
                    System.Console.WriteLine("Please enter Website !");
                    company.Website = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.Company SET Website = @Website where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Website", company.Website);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateCompany";

                case "6":
                    /*try
                    {
                        Log.Information("Adding record \n" + newcompany);
                        repo.Add(newcompany);
                        Log.Information("Successful at adding Record!");
                    }
                    catch (Exception exc)
                    {
                        Log.Error($"Failed to add Record - {exc.Message}");
                        System.Console.WriteLine(exc.Message);
                        System.Console.WriteLine("Please press Enter to continue");
                        System.Console.ReadLine();
                    }*/
                    System.Console.WriteLine("saved successfully");
                    System.Console.ReadKey();
                    return "UpdateCompany";
                case "7":
                    return "GetComDetails";
                default:
                    System.Console.WriteLine("Please input a valid response");
                    System.Console.WriteLine("Please press Enter to continue");
                    System.Console.ReadLine();
                    return "UpdateCompany";
            }
        }
    }
}
