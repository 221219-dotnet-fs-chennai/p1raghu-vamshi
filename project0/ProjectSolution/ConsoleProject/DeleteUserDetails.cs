using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class DeleteUserDetails:IMenu
    {
        static UserDetails newupdate = new UserDetails();

        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        IFile repo = new SqlRepo(constr);

        int pid = Validate.Pid();

        public void Display()
        {
            //  newupdate = repo.GetAllDetails();
            System.Console.WriteLine();
            System.Console.WriteLine("@@@@@@@@@@@@  Delete User Details @@@@@@@@@@@@");
            System.Console.WriteLine();
            System.Console.WriteLine("[1] To Delete Salutation      - " + newupdate.Salutation);
            System.Console.WriteLine("[2] To Delete FirstName      - " + newupdate.FirstName);
            System.Console.WriteLine("[3] To Delete MiddleName      - " + newupdate.MiddleName);
            System.Console.WriteLine("[4] To Delete LastName       - " + newupdate.LastName);
            System.Console.WriteLine("[5] To Delete Email          - " + newupdate.Email);
            System.Console.WriteLine("[6] To Delete Password        - " + newupdate.Password);
            System.Console.WriteLine("[7] To Deletee Gender         - " + newupdate.Gender);
            System.Console.WriteLine("[8] To Delete Age            - " + newupdate.Age);
            System.Console.WriteLine("[9] save");
            System.Console.WriteLine("[0] Go Back");

        }

        public string UserChoice()
        {
            string userInput = System.Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    System.Console.WriteLine("Please enter to delete Salutation!");
                    string Salutation = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.UserDetails where Salutation = @Salutation and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Salutation", Salutation);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteUserDetails";
                case "2":
                    System.Console.WriteLine("Please enter to delete First name!");
                    string FirstName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.UserDetails where Firstname = @FirstName and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", FirstName);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteUserDetails";
                case "3":
                    System.Console.WriteLine("Please enter to delete Middle name!");
                    string MiddleName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.UserDetails where MiddleName = @MiddleName and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@MiddleName", MiddleName);
                            command.ExecuteNonQuery();

                        }
                    }
                    return " DeleteUsereDetails";
                case "4":
                    System.Console.WriteLine("Please enter to delete Last name!");
                    string LastName = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.UserDetails where Lastname =@LastName and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@LastName", LastName);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteUserDetails";
                case "5":
                    System.Console.WriteLine("Please enter to delete Email!");
                    string Email = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.UserDetails where Email = @Email and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Email", Email);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteUserDetails";
                case "6":
                    System.Console.WriteLine("Please enter to delete Password!");
                    string Password = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.UserDetails where Password = @Password and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Password", Password);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteUserDetails";
                case "7":
                    System.Console.WriteLine("Please enter to delete Gender");
                    string Gender = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.UserDetails where Gender = @Gender and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Gender", Gender);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteUserDetails";
                case "8":
                    System.Console.WriteLine("Please enter to delete Age!");
                    int Age = Convert.ToInt32(System.Console.ReadLine());
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.UserDetails where Age = @Age and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@Age", Age);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteUserDetails";
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
                    return "DeleteUserDetails";
                case "0":
                    return "GetUserDetails";
                default:
                    System.Console.WriteLine("Please input a valid response");
                    System.Console.WriteLine("Please press Enter to continue");
                    System.Console.ReadLine();
                    return "DeleteUserDetails";
            }
        }
    }
}
