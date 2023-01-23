using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Collections;
using ProjestLibrary;
using ConsoleProject;

namespace ConsoleProject
{
    public class Validate  : IMenu
    {
        static string constr = File.ReadAllText("C:/AssociatesLink/Azurelink.txt");
        static string wrongpswd = "";
        static string e = "";
        string p;

        public void Display()
        {
            System.Console.WriteLine("Enter User Details");
            System.Console.WriteLine($"{wrongpswd}");
        }

        public string UserChoice()
        {
            System.Console.Write("Enter Email:");
            e = System.Console.ReadLine();
            string path = "C:/AssociatesLink/Azurelink.txt";
            string cs = File.ReadAllText(path);
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Email FROM Raghu.UserDetails WHERE Email = @email", connection))
                {
                    command.Parameters.AddWithValue("@email", e);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Close();
                            System.Console.Write("Enter Password:");
                            p = System.Console.ReadLine();
                            SqlCommand cmd = new SqlCommand("SELECT Password from Raghu.UserDetails where Password = @password", connection);
                            cmd.Parameters.AddWithValue("@password", p);
                            SqlDataReader reader1 = cmd.ExecuteReader();
                            if (reader1.HasRows)
                            {
                                return "LoginUp";
                            }
                            else
                            {
                                wrongpswd = "wrong password please retry...";
                                return "Validate";
                            }
                        }
                        else
                        {
                            return "Signup";
                        }
                    }
                }
            }
        }

        public static int Pid()
        {
            int id = 0;
            using SqlConnection con = new SqlConnection(constr);
            con.Open();
            string query = $"select  UserId from Raghu.UserDetails where Email = @email";
            using SqlCommand sqlcommand = new SqlCommand(query, con);
            sqlcommand.Parameters.AddWithValue("@email", e);
            using SqlDataReader sqlDataReaderreader = sqlcommand.ExecuteReader();
            if (sqlDataReaderreader.Read())
            {
                id = sqlDataReaderreader.GetInt32(0);
            }
            return id;
        }
        public static string Login()
        {
            return e;
        }

    }
}
