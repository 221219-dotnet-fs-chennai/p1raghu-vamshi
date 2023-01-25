
using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class DeleteAddressDetails:IMenu
    {
        static Address address = new Address();
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        IFile repo = new SqlRepo(constr);
        int pid = Validate.Pid();
        public void Display()
        {
            // address = repo.GetAddDetails();
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------");
            System.Console.WriteLine("****************************************** Delete Address ***********************************");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
            System.Console.WriteLine("[1] To Delete userAddress                     - " + address.userAddress);
            System.Console.WriteLine("[2] To Delete country                     - " + address.country);
            System.Console.WriteLine("[3] To Delete pincode                     - " + address.pincode);
            System.Console.WriteLine("[4] save");
            System.Console.WriteLine("[5] Go Back");
        }
        public string UserChoice()
        {
            string userInput = System.Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    System.Console.WriteLine("Please enter To delete userAddress!");
                    address.userAddress = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.Address where userAddress = @userAddress and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@CompanyName", address.userAddress);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteAddress";
                case "2":
                    System.Console.WriteLine("Please enter To delete country!");
                    address.country = System.Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.Address where country = @country and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@CompanyLocation", address.country);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteAddress";
                case "3":
                    System.Console.WriteLine("Please enter to delete pincode!");
                    address.pincode = Convert.ToInt32(System.Console.ReadLine());
                    using (SqlConnection connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand($"Delete From Raghu.Address where pincode = @pincode and userId = {pid}", connection))
                        {
                            command.Parameters.AddWithValue("@pincode", address.pincode);
                            command.ExecuteNonQuery();
                        }
                    }
                    return "DeleteAddress";
               case "4":
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
                    return "UpdateAddress";
                case "5":
                    return "GetAddDetails";
                default:
                    System.Console.WriteLine("Please input a valid response");
                    System.Console.WriteLine("Please press Enter to continue");
                    System.Console.ReadLine();
                    return "DeleteAddress";
            }
        }
    }
}
