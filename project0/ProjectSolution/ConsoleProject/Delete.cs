using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class Delete : IMenu
    {
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        public void Display()
        {
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------");
            System.Console.WriteLine("******************************************* Delete *****************************************");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------");
            System.Console.WriteLine("[0] - Back");
            System.Console.WriteLine("[1] - Delete");
        }
        public string UserChoice()
        {
            string userinput = System.Console.ReadLine();
            if (userinput == "0")
            {
                return "LoginUp";
            }
            else
            {
                int id = Validate.Pid();
                using SqlConnection con = new SqlConnection(constr);
                con.Open();
                string query = $"Delete Raghu.UserDetails where userId = {id}";
                using SqlCommand sqlcommand = new SqlCommand(query, con);
                sqlcommand.Parameters.AddWithValue("@userId", id);
                sqlcommand.ExecuteNonQuery();

                return "Menu";
            }
        }
    }
}
