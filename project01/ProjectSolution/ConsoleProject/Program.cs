global using Serilog;
using System.Data;
using ProjectLibrary;
namespace ConsoleProject
{
    class Program
    {
        // public static object UserInteraction { get; private set; }
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
      .WriteTo.File(@"..\..\..\Logs\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
      .CreateLogger();

            Log.Logger.Information("----Program starts----");
            // UserInteraction.GetUserDetails();
            Log.Logger.Information("----Program Ends----");

            bool repeat = true;
            IMenu menu = new Menu();
            while (repeat)
            {
                Console.Clear();
                menu.Display();
                string ans = menu.UserChoice();
                switch (ans)
                {
                   /* case "SignUp":
                        Log.Information("Displaying SignUp details menu to user");
                        menu = new SignUp();
                        break;
                    case "Raghu.Login":
                         Log.Information("Displaying Login details menu to user");
                        menu = new Raghu.Login();*/
                    case "AddLoginDetails":
                        Log.Information("Displaying Add details menu to user");
                        menu = new AddLoginDetails();
                        break;
                    case "GetLoginDetails":
                        Log.Information("Displaying add details menu to user");
                       menu = new GetLoginDetails();
                       break;
                    case "AddUserDetails":
                        Log.Information("Displaying add details menu to user");
                        menu = new AddUserDetails();
                       break;
                    case "GetUserDetails":
                        menu = new GetUserDetails();
                        break;
                    case "GetEducationDetails":
                        menu = new GetEducationDetails();
                        break;
                    case "AddEducationDetails":
                        menu = new AddEducationDetails();
                        break;
                    case "GetCompanyDetails":
                        menu = new GetCompanyDetails();
                        break;
                    case "AddCompanyDetails":
                        menu = new AddCompanyDetails();
                        break;
                    case "GetAddressDetails":
                        menu = new GetAddressDetails();
                        break;
                    case "AddAddressDetails":
                        menu = new AddAddressDetails();
                        break;
                    case "Menu":
                        Log.Information("Displaying main menu to user");
                        menu = new Menu();
                        break;
                    case "exit":
                        Log.Information("Exiting application");
                        Log.CloseAndFlush(); //To close our logger resource
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Page does not exist!");
                      Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}
