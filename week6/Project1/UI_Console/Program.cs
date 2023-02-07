/*global using serilog;
using system.data;
using system;

namespace ui_console
{
    class program
    {
        public static void main(string[] args)
        {
            log.logger = new loggerconfiguration()
                    .writeto.file(@"..\..\..\logs\logs.txt", rollinginterval: rollinginterval.day, rollonfilesizelimit: true)
                            .createlogger();
            log.logger.information("----program starts----");

            bool repeat = true;
            iclass class = new class();
            while (repeat)
            {
                console.clear();
                class.display();
                string ans = class.userchoice();
                switch (ans)
                {
                    case "adduserdetails":
                        log.information("displaying add user details to user");
                        class = new adduserdetails();
                        break;
                    case "getuserdetails":
                        class = new getuserdetails();
                        break;
                    case "class":
                        log.information("displaying main class to user");
                        class = new class();
                        break;
                    case "exit":
                        log.information("existing application");
                        log.closeandflush();
                        repeat = false;
                        break;
                    default:
                        console.writeline("page does not exist!");
                        console.writeline("please press enter to continue");
                        console.readline();
                        log.logger.information("----program ends----");
                        break;


                }
            }

        }
    }
}
*/