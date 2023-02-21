using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules;
using EntityApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityApi
{
    public class AddressSqlRepo:IAddressRepo<Entities.Address>
    {
        public AddressSqlRepo() { }
        Entities.AssociatesDbContext context = new Entities.AssociatesDbContext();
        public Entities.Address Add(Entities.Address address)
        {
            context.Address.Add(address);
            context.SaveChanges();
            return address;
        }
        public List<Entities.Address> GetAddress()
        {
            return context.Address.ToList();
        }
        public IEnumerable<Entities.Address> Get(int t)
        {
            var id = context.Address.Where(i => i.UserId == t);
            return id;
        }
        public Entities.Address RemoveAddress(int UserId)
        {
            var id = context.Address.Where(t => t.UserId == UserId).FirstOrDefault();
           // if (search != null)
            
                context.Address.Remove(id);// this will generate DELETE query of Sql to be passed to Database
                context.SaveChanges();
            
            return id;
        }
        public Entities.Address UpdateAddress(Entities.Address a)
        {
            context.Address.Update(a);// this will generate UPDATE sql query to be passed to databse via ADO.Net
            context.SaveChanges();
            return a;
        }
    }
}
