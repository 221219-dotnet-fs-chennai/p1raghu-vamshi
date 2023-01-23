global using Serilog;
using System.Data;
//using ProjectLibrary;
using ProjestLibrary;

namespace ConsoleProject
{
    class Program
    {
        // public static object UserInteraction { get; private set; }
        public static void Main(string[] args)
        {
            UserDetails details = new UserDetails();
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
                    case "SignUp":
                        Log.Information("Displaying SignUp details menu to user");
                        SignUp signup = new SignUp();
                        menu = new SignUp();
                        break;
                    case "Validate":
                         Log.Information("Displaying Login details menu to user");
                        menu =  new Validate();
                        break;
                    case "LoginUp":
                        Log.Information("Displaying Login details menu to user");
                        menu = new LoginUp();
                        break;
                    case "Delete":
                        Log.Information("Deleting the user");
                        menu = new Delete();
                        break;
                    case "Update":
                        Log.Information("Updating the All Details");
                        menu = new Update();
                        break;                 
                    case "AddUserDetails":
                          Log.Information("Displaying add details menu to user");
                          menu = new AddUserDetails();
                         break;
                      case "GetUserDetails":
                          menu = new GetUserDetails();
                          break;
                     /* case "AddLoginDetails":
                          Log.Information("Displaying Add details menu to user");
                          menu = new AddLoginDetails();
                          break;
                      case "GetLoginDetails":
                          Log.Information("Displaying add details menu to user");
                          menu = new GetLoginDetails();
                          break;*/
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
                      case "AddSkillsDetails":
                          menu = new AddSkillsDetails();
                          break;
                      case "GetSkillsDetails":
                          menu = new GetSkillsDetails();
                          break;
                    case "UpdateAddress":
                        menu = new UpdateAddress();
                        break;
                    case "UpdateCompany":
                        menu = new UpdateCompany();
                        break;
                    case "UpdateDetails":
                        menu = new UpdateDetails();
                        break;
                    case "UpdateEducation":
                        menu = new UpdateEducation();
                        break;
                    case "UpdateSkills":
                        menu = new UpdateSkills();
                        break;
                    case "Menu":
                        Log.Information("Displaying main menu to user");
                        menu = new Menu();
                        break;
                    case "Exit":
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
