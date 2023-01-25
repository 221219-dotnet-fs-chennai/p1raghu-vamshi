using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class DeleteCompanyDetails:IMenu
    {

        static Company company = new Company();
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        IFile repo = new SqlRepo(constr);
        int pid = Validate.Pid();
        public void Display()
        {
            // company = repo.GetComDetails();
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------");
            System.Console.WriteLine("****************************************** Delete Company Details **********************************");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
            System.Console.WriteLine("[1] To Delete Company Name         - " + company.CompanyName);
            System.Console.WriteLine("[2] To Delete Company Name         - " + company.CompanyName);
            System.Console.WriteLine("[3] To Delete Experience            - " + company.Experience);
            System.Console.WriteLine("[4] To Delete Company Email         - " + company.CompanyEmail);
            System.Console.WriteLine("[5] To Delete Website           - " + company.Website);
            System.Console.WriteLine("[6] save");
            System.Console.WriteLine("[7] Go Back");

        }

        public string UserChoice()
        {
            string userInput = System.Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    System.Console.WriteLine("Please enter To Delete CompanyName!");
                    company.CompanyName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($" Delete From Raghu.Company where CompanyName = @CompanyName and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@CompanyName", company.CompanyName);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteCompanyDetails";
                case "2":
                    System.Console.WriteLine("Please enter To Delete CompanyLocation!");
                    company.CompanyLocation = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($" Delete From Raghu.Company where CompanyLocation = @CompanyLocation and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@CompanyLocation", company.CompanyLocation);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteCompanyDetails";
                case "3":
                    System.Console.WriteLine("Please enter To Delete Experience!");
                    company.Experience = Convert.ToInt32(System.Console.ReadLine());
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($" Delete From Raghu.Company where experience = @Experience and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Experience", company.Experience);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteCompanyDetails";
                case "4":
                    System.Console.WriteLine("Please enter To Delete CompanyEmail !");
                    company.CompanyEmail = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($" Delete From Raghu.Company where CompanyEmail = @CompanyEmail and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@CompanyEmail", company.CompanyEmail);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteCompanyDetails";
                case "5":
                    System.Console.WriteLine("Please enter To Delete Website !");
                    company.Website = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($" Delete from Raghu.Company where Website = @Website and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Website", company.Website);
                            command.ExecuteNonQuery();
                        }
                    }
                    return " DeleteCompanyDetails";

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
                    return " DeleteCompanyDetails";
                case "7":
                    return "GetComDetails";
                default:
                    System.Console.WriteLine("Please input a valid response");
                    System.Console.WriteLine("Please press Enter to continue");
                    System.Console.ReadLine();
                    return " DeleteCompanyDetails";
            }
        }
    }
}
