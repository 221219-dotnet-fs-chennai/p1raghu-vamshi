using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class UpdateDetails :IMenu
    {
        static UserDetails newupdate = new UserDetails();

        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        IFile repo = new SqlRepo(constr);

        int pid = Validate.Pid();

        public void Display()
        {
            //  newupdate = repo.GetAllDetails();
            System.Console.WriteLine();
            System.Console.WriteLine("@@@@@@@@@@@@  Update Trainer Details @@@@@@@@@@@@");
            System.Console.WriteLine();
            System.Console.WriteLine("[1] Update Salutation      - " + newupdate.Salutation);
            System.Console.WriteLine("[2] Update FirstName      - " + newupdate.FirstName);
            System.Console.WriteLine("[3] Update MiddleName      - " + newupdate.MiddleName);
            System.Console.WriteLine("[4] Update LastName       - " + newupdate.LastName);
            System.Console.WriteLine("[5] Update Email          - " + newupdate.Email);
            System.Console.WriteLine("[6] UpdatePassword        - " + newupdate.Password);
            System.Console.WriteLine("[7] Update Gender         - " + newupdate.Gender);
            System.Console.WriteLine("[8] Update Age            - " + newupdate.Age);
            System.Console.WriteLine("[9] save");
            System.Console.WriteLine("[0] Go Back");

        }

        public string UserChoice()
        {
            string userInput = System.Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    System.Console.WriteLine("Please enter a Salutation!");
                    string Salutation = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.UserDetails SET Salutation = @Salutation where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Salutation", Salutation);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateDetails";
                case "2":
                    System.Console.WriteLine("Please enter a First name!");
                    string FirstName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.UserDetails SET Firstname = @FirstName where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", FirstName);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateDetails";
                case "3":
                    System.Console.WriteLine("Please enter a Middle name!");
                    string MiddleName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.UserDetails SET MiddleName = @MiddleName where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", MiddleName);
                            command.ExecuteNonQuery();
                           
                        }
                    }
                     return "UpdateDetails";
                case "4":
                    System.Console.WriteLine("Please enter a Last name!");
                    string LastName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.UserDetails SET Lastname = @LastName where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", LastName);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateDetails";
                case "5":
                    System.Console.WriteLine("Please enter New Email!");
                    string Email = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.UserDetails SET Email = @Email where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Email", Email);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateDetails";
                case "6":
                    System.Console.WriteLine("Please enter New Password!");
                    string Password = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.UserDetails SET password = @Password where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@password", Password);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateDetails";
                case "7":
                    System.Console.WriteLine("Please enter Gender");
                    string Gender = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.UserDetails SET gender = @Gender where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@gender", Gender);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateDetails";
                case "8":
                    System.Console.WriteLine("Please enter Age!");
                    int Age = Convert.ToInt32(System.Console.ReadLine());
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"UPDATE Raghu.UserDetails SET age = @Age where userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@age", Age);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "UpdateDetails";
                case "9":
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
                    }*/
                    System.Console.WriteLine("saved successfully");
                    System.Console.ReadKey();
                    return "UpdateDetails";
                case "0":
                    return "LoginUp";
                default:
                    System.Console.WriteLine("Please input a valid response");
                    System.Console.WriteLine("Please press Enter to continue");
                    System.Console.ReadLine();
                    return "UpdateDetails";
            }
        }
    }
}
