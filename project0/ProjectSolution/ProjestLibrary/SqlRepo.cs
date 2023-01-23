//using ConsoleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ProjestLibrary
{
    public class SqlRepo : IFile
    {
        
        private readonly string connectionString;
        public SqlRepo  (string connectionString)
        {
            this.connectionString = connectionString;

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
    
        public List<Login> GetDetails()
        {
            List<Login> login = new List<Login>();
            // establish the connection
            try
            {
                using SqlConnection con = new SqlConnection("C:/AssociatesLink/Azurelink.txt");
                con.Open();               
                string query = "select userId, Email, Password from Raghu.Login";
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = command.ExecuteReader();
                // process the output
                while (reader.Read())
                {
                    login.Add(new Login()
                    {
                        userId = reader.GetInt32(0),
                        Email = reader.GetString(1),
                        Password = reader.GetString(2),
                    }); ;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return login;
        } */
       

        public UserDetails Add(UserDetails userDetails)
        {
            string query = @"insert into Raghu.UserDetails (userId, Age, Salutation ,FirstName, MiddleName, LastName, Gender, Email,Password) values (@userId, @Age, @Salutation, @FirstName, @MiddleName, @LastName, @Gender, @Email, @Password)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@userId", userDetails.userId);
            sqlCommand.Parameters.AddWithValue("@Age", userDetails.Age);
            sqlCommand.Parameters.AddWithValue("@Salutation", userDetails.Salutation);
            sqlCommand.Parameters.AddWithValue("@FirstName", userDetails.FirstName);
            sqlCommand.Parameters.AddWithValue("@MiddleName", userDetails.MiddleName);
            sqlCommand.Parameters.AddWithValue("@LastName", userDetails.LastName);
            sqlCommand.Parameters.AddWithValue("@Gender", userDetails.Gender);
            sqlCommand.Parameters.AddWithValue("@Email", userDetails.Email);
            sqlCommand.Parameters.AddWithValue("@Password", userDetails.Password);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            
            return userDetails;
        }
        public List<UserDetails> GetAllDetails()
        {
            List<UserDetails> userDetails = new List<UserDetails>();
            // establish the connection
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();               
                string query = "select userId, Age, Salutation, FirstName, MiddleName,LastName,Gender,Email,Password from Raghu.UserDetails"; 
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = command.ExecuteReader();
                // process the output
                while (reader.Read())
                {
                    userDetails.Add(new UserDetails()
                    {
                        userId = reader.GetInt32(0),
                        Age = reader.GetInt32(1),
                        Salutation = reader.GetString(2),
                        FirstName = reader.GetString(3),
                        MiddleName = reader.GetString(4),
                        LastName = reader.GetString(5),
                        Gender = reader.GetString(6),
                        Email = reader.GetString(7),
                        Password = reader.GetString(8),
                    }); ;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return userDetails;
        }
        public List<UserDetails> GetSpecificDetails(string email)
        {
            List<UserDetails> userDetails = new List<UserDetails>();
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = $"select userId, Age, Salutation, FirstName, MiddleName,LastName,Gender,Email,Password from Raghu.UserDetails where Email = '{email}'";
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = command.ExecuteReader();
                // process the output
                while (reader.Read())
                {
                    userDetails.Add(new UserDetails()
                    {
                        userId = reader.GetInt32(0),
                        Age = reader.GetInt32(1),
                        Salutation = reader.GetString(2),
                        FirstName = reader.GetString(3),
                        MiddleName = reader.GetString(4),
                        LastName = reader.GetString(5),
                        Gender = reader.GetString(6),
                        Email = reader.GetString(7),
                        Password = reader.GetString(8),
                    }); ;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return userDetails;
        }

        public Education Add(Education education)
        {
            string query = @"insert into Raghu.Education (userId,University,UG,Specialization,PassedOutYear,grade) values (@UserId ,@University,@UG,@Specialization,@PassedOutYear,@grade)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@userId", education.userId);
            sqlCommand.Parameters.AddWithValue("@University", education.University);
            sqlCommand.Parameters.AddWithValue("@UG", education.UG);
            sqlCommand.Parameters.AddWithValue("@Specialization", education.Specialization);
            sqlCommand.Parameters.AddWithValue("@PassedOutYear", education.PassedOutYear);
            sqlCommand.Parameters.AddWithValue("@grade", education.grade);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            return education;
        }
        public List<Education> GetEduDetails()
        {
            List<Education> education = new List<Education>();
            // establish the connection
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                // fire the query
                // for associates - uncomment first
                //string query = "select Id, Name, OpenTime, CloseTime, Zipcode from Training.Restaurants";
                // for trainer
                string query = "select userId, University,UG,Specialization,PassedOutYear,grade from Raghu.Education";
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = command.ExecuteReader();
                // process the output
                while (reader.Read())
                {
                    education.Add(new Education()
                    {
                        userId = reader.GetInt32(0),
                        University = reader.GetString(1),
                        UG = reader.GetString(2),
                        Specialization = reader.GetString(3),
                        PassedOutYear = reader.GetInt32(4),
                        grade = reader.GetString(5),
                    }); ;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return education;
        }
        public Company Add(Company company)
        {
            string query = @"insert into Raghu.Company (userId,CompanyName,CompanyLocation,Experience,CompanyEmail,Website) values (@UserId ,@CompanyName,@CompanyLocation,@Experience,@CompanyEmail,@Website)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@userId", company.userId);
            sqlCommand.Parameters.AddWithValue("@CompanyName", company.CompanyName);
            sqlCommand.Parameters.AddWithValue("@CompanyLocation", company.CompanyLocation);
            sqlCommand.Parameters.AddWithValue("@Experience", company.Experience);
            sqlCommand.Parameters.AddWithValue("@CompanyEmail", company.CompanyLocation);
            sqlCommand.Parameters.AddWithValue("@Website", company.Website);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            return company;
        }
        public List<Company> GetComDetails()
        {
            List<Company> company = new List<Company>();
            // establish the connection
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "select userId,CompanyName,CompanyLocation,Experience,CompanyEmail,Website  from Raghu.Company";
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    company.Add(new Company()
                    {
                        userId = reader.GetInt32(0),
                        CompanyName = reader.GetString(1),
                        CompanyLocation = reader.GetString(2),
                        Experience = reader.GetInt32(3),
                        CompanyEmail = reader.GetString(4),
                        Website = reader.GetString(5),
                    }); ;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return company;
        }
        public Address Add(Address address)
        {
            string query = @"insert into Raghu.Address (userId,userAddress,country,pincode) values (@UserId ,@userAddress,@country,@pincode)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@userId", address.userId);
            sqlCommand.Parameters.AddWithValue("@userAddress", address.userAddress);
            sqlCommand.Parameters.AddWithValue("@country", address.country);
            sqlCommand.Parameters.AddWithValue("@pincode", address.pincode);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            return address;


        }
        public List<Address> GetAddDetails()
        {
            List<Address> address = new List<Address>();
            // establish the connection
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "select userId,userAddress,country,pincode  from Raghu.Address";
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    address.Add(new Address()
                    {
                        userId = reader.GetInt32(0),
                        userAddress = reader.GetString(1),
                        country = reader.GetString(2),
                        pincode = reader.GetInt32(3),
                    }); ;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return address;
        }
        public Skills Add(Skills skills)
        {
            string query = @"insert into Raghu.Skills (userId,SkillName) values (@UserId ,@SkillName)";
            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.Parameters.AddWithValue("@userId", skills.userId);
            sqlCommand.Parameters.AddWithValue("@SkillName", skills.SkillName);
            int rows = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(rows + "row(s) added");
            return skills;

        }
        public List<Skills> GetSkillDetails()
        {
            List<Skills> skills = new List<Skills>();
            // establish the connection
            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "select userId,SkillName  from Raghu.Skills";
                using SqlCommand command = new SqlCommand(query, con);
                // execute it
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    skills.Add(new Skills()
                    {
                        userId = reader.GetInt32(0),
                        SkillName = reader.GetString(1),                       
                    }); ;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return skills;
        }
    }
} 
    
