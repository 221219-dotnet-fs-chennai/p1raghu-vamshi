using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using EntityApi.Entities;

namespace BusinessLogic
{
    public class Validation
    {
        AssociatesDbContext context;
        public Validation(AssociatesDbContext _context)
        {
            context = _context;
        }
        public bool isEmailPresent(string Email)
        {
            try
            {
                if (context.UserDetails.Where(t => t.Email == Email).First() != null)
                {
                    return true;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
        public bool signIn(string Email, string Password)
        {
            try
            {
                if (context.UserDetails.Where(t => t.Email == Email && t.Password == Password).First() != null)
                {
                    return true;
                }
                else
                {
                    throw new System.InvalidOperationException();
                }
            }
            catch (System.InvalidOperationException)
            {
                return false;
            }

        }
    }
}
