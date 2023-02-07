/*global using Serilog;
using System.Data;
using System;

namespace UI_Console
{
    class Program
    {
        public static void Main(string[] args) {
            Log.Logger = new LoggerConfiguration()
                    .WriteTo.File(@"..\..\..\Logs\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                            .CreateLogger();
            Log.Logger.Information("----Program starts----");

            bool repeat = true;
            IClass Class = new Class();
            while (repeat)
            {
                Console.Clear();
                Class.Display();
                string ans = Class.UserChoice();
                switch (ans) 
                {
                    case "AddUserdetails":
                        Log.Information("Displaying Add User Details to user");
                        Class = new AddUserDetails();
                        break;
                    case "GetUserDetails":
                        Class= new GetUserDetails();
                        break;
                    case "Class":
                        Log.Information("Displaying Main Class to user");
                        Class = new Class();
                        break;
                    case "Exit":
                        Log.Information("Existing Application");
                        Log.CloseAndFlush();
                        repeat= false;
                        break;
                    default:
                        Console.WriteLine("Page does not exist!");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        Log.Logger.Information("----Program ends----");
                        break;


                }
            }

        }
    }
}
*/