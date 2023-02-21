using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class TValidation
    {
        public TValidation() { }
        public  bool IsValidEmail(string Email)
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            if (!Regex.IsMatch(Email, pattern, RegexOptions.IgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public  bool IsValidPassword(string str)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
            if (!Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsValidWebsite(string str)
        {
            string pattern = @"^((https?|ftp|smtp):\/\/)?(www.)?[a-z0-9]+\.[a-z]+(\/[a-zA-Z0-9#]+\/?)*$";
            if (!Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsValidGender(string str)
        {
            string pattern = "^((male?|female|others))?$";
            if (!Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsValidSkillName(string str)
        {
            string pattern = @"^.{2,}$";
            if (!Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
