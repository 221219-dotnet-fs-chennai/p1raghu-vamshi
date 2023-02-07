using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Security;

namespace BusinessLogic
{
    public class Validate
    {
        static string constr = File.ReadAllText(".../../../Logs/logs.txt");
        static string wrongpswd = "";
        static string e = "";

        public void Display()
        {
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------");
            System.Console.WriteLine("********************************************* Validation **************************************");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
            System.Console.WriteLine($"{wrongpswd}");
        }
        public string UserChoice()
        {
            System.Console.Write("Enter Login Email:");
            e = System.Console.ReadLine();
            string path = ".../../../Logs/logs.txt";
            string cs = File.ReadAllText(path);
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Email FROM UserDetails WHERE Email = @email", connection))
                {
                    command.Parameters.AddWithValue("@email", e);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Close();
                            string p = "";
                            System.Console.Write("Enter Login Password: ");
                            ConsoleKeyInfo key;
                            do
                            {
                                key = System.Console.ReadKey(true);
                                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                                {
                                    p += key.KeyChar;
                                    System.Console.Write("*");
                                }
                                else
                                {
                                    if (key.Key == ConsoleKey.Backspace && p.Length > 0)
                                    {
                                        p = p.Substring(0, (p.Length - 1));
                                        System.Console.Write("\b \b");
                                    }
                                }
                            }
                            while (key.Key != ConsoleKey.Enter);
                            SqlCommand cmd = new SqlCommand("SELECT Password from UserDetails where Password = @password", connection);
                            cmd.Parameters.AddWithValue("@password", p);
                            SqlDataReader reader1 = cmd.ExecuteReader();
                            if (reader1.HasRows)
                            {
                                return "Login";
                            }
                            else
                            {
                                wrongpswd = "Wrong password please enter your \"Email\" and \"Password\"....!";
                                return "Validate";
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Looks like your Email is not in our Database \nPress Enter To Redirect to Signup Page");
                            System.Console.ReadKey();
                            return "Signup";
                        }
                    }
                }
            }
        }

        public static int Pid()
        {
            int userId = 0;
            using SqlConnection con = new SqlConnection(constr);
            con.Open();
            string query = $"select userId from UserDetails where Email = @email";
            using SqlCommand sqlcommand = new SqlCommand(query, con);
            sqlcommand.Parameters.AddWithValue("@email", e);
            using SqlDataReader sqlDataReaderreader = sqlcommand.ExecuteReader();
            if (sqlDataReaderreader.Read())
            {
                userId = sqlDataReaderreader.GetInt32(0);
            }
            return userId;
        }

    }
}
