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
            context.Add(address);
            context.SaveChanges();
            return address;
        }
        public List<Entities.Address> GetAddress()
        {
            return context.Address.ToList();
        }
        public Entities.Address RemoveAddress(long PhoneNumber)
        {
            var search = context.Address.Where(t => t.PhoneNumber == PhoneNumber).FirstOrDefault();
            if (search != null)
            {
                context.Address.Remove(search);// this will generate DELETE query of Sql to be passed to Database
                context.SaveChanges();
            }
            return search;
        }
        public Entities.Address UpdateAddress(Entities.Address t)
        {
            context.Address.Update(t);// this will generate UPDATE sql query to be passed to databse via ADO.Net
            context.SaveChanges();
            return t;
        }
    }
}
