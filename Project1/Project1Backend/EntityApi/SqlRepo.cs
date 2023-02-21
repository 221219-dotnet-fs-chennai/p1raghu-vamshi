using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules;
using EntityApi.Entities;
using Microsoft.EntityFrameworkCore;
//using Modules;
namespace EntityApi
{
    public class SqlRepo : IRepo<Entities.UserDetail>
    {
        public SqlRepo() { }
        Entities.AssociatesDbContext context = new Entities.AssociatesDbContext();
        public Entities.UserDetail Add(Entities.UserDetail userDetails)
        {
            context.Add(userDetails);
            context.SaveChanges();
            return userDetails;
        }
        public List<Entities.UserDetail> GetUserDetails()
        {
            return context.UserDetails.ToList();
        }
        public IEnumerable< UserDetail> Get(int t)
        {
            var search = context.UserDetails.Where(m => m.UserId ==t);
            return search;
        }
        public Entities.UserDetail RemoveUserDetails(int UserId)
        {
            var search = context.UserDetails.Where(t => t.UserId == UserId).FirstOrDefault();
           // if (search != null)
            
                context.UserDetails.Remove(search);// this will generate DELETE query of Sql to be passed to Database
                context.SaveChanges();
            
            return search;
        }
        public Entities.UserDetail UpdateUserDetails(Entities.UserDetail t)
        {
            context.UserDetails.Update(t);// this will generate UPDATE sql query to be passed to databse via ADO.Net
            context.SaveChanges();
            return t;
        }
    }
}
