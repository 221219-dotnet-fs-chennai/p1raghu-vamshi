using ProjestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class GettingTranierDetails:IMenu
    {
        static string constr = ($"C:/AssociatesLink/Azurelink.txt");
        SqlRepo userobj = new SqlRepo(constr);
        SqlRepo skillobj = new SqlRepo(constr);
        SqlRepo eduobj = new SqlRepo(constr);
        SqlRepo comobj = new SqlRepo(constr);
        SqlRepo addobj = new SqlRepo(constr);
 
        int Id = Validate.Pid();
        string email = Validate.Login();
        public void Display()
        {
            Log.Logger.Information("--------------------------------Displayed All Info------------------------------------------");
            System.Console.WriteLine("-------------------------------User Details------------------------------------------");
            System.Console.WriteLine($"{userobj.GetSpecificDetails( email).ToString()}");
            System.Console.WriteLine("-------------------------------Skill Details-----------------------------------------");
            System.Console.WriteLine($"{skillobj.GetSkillDetails(Id).ToString()}");
            System.Console.WriteLine("-------------------------------Education Details-------------------------------------");
            System.Console.WriteLine($"{eduobj.GetEduDetails(Id).ToString()}");
            System.Console.WriteLine("------------------------------Company Details----------------------------------------");
            System.Console.WriteLine($"{comobj.GetComDetails(Id).ToString()}");
            System.Console.WriteLine("------------------------------Address Details-------------------------------------");
            System.Console.WriteLine($"{addobj.GetAddDetails(Id).ToString()}");
        }

        public string userChoice()
        {
            System.Console.ReadLine();
            return "LoginUp";
        }     

        string IMenu.UserChoice()
        {
            throw new NotImplementedException();
        }
    }
} 
