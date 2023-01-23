/*using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
//using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{

    public class SignUp:Menu
    {
        public SignUp()
        {
            Login login = new Login();
            Console.WriteLine("Enter an Email");
            login.Email = Console.ReadLine();
            string query = $"select Email from Login where Email={login.Email}";
            using SqlConnection con = new SqlConnection("C:/AssociatesLink/Azurelink.txt");
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine("Email Already Exists");
            }
            else
            {
                Console.WriteLine("Enter the Password");

            }
            /* public Login Add(Login login)
           {
               string query = @"insert into Raghu.Login (userId,Email, Password) values (@UserId ,@Email, @Password)";
               using SqlConnection con = new SqlConnection("C:/AssociatesLink/Azurelink.txt");
               con.Open();
               SqlCommand sqlCommand = new SqlCommand(query, con);
               sqlCommand.Parameters.AddWithValue("@userId", login.userId);
               sqlCommand.Parameters.AddWithValue("@Email", login.Email);
               sqlCommand.Parameters.AddWithValue("@Password", login.Password);
               int rows = sqlCommand.ExecuteNonQuery();
               Console.WriteLine(rows + "row(s) added");
               return login;
           }
       }
        }
    }
}*/
