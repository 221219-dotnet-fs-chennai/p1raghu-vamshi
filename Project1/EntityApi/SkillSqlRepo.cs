using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityApi.Entities;
using Microsoft.EntityFrameworkCore;
using Modules;

namespace EntityApi
{
    public class SkillSqlRepo : ISkillRepo<Entities.Skill>
    {
        public SkillSqlRepo() { }
        Entities.AssociatesDbContext context = new Entities.AssociatesDbContext();
        public Entities.Skill Add(Entities.Skill skill)
        {
            context.Add(skill);
            context.SaveChanges();
            return skill;
        }
        public List<Entities.Skill> GetSkills()
        {
            return context.Skills.ToList();
        }
        public IEnumerable<Entities.Skill> Get(int id)
        {
            var mail = context.Skills.Where(i => i.UserId == id);
            return mail;
        }

        public Entities.Skill RemoveSkills(int SkillId)
        {
            var id = context.Skills.Where(t => t.SkillId == SkillId).FirstOrDefault();
           // if (search != null)
            
                context.Skills.Remove(id);// this will generate DELETE query of Sql to be passed to Database
                context.SaveChanges();
            
            return id;

        }
        public Entities.Skill UpdateSkills(Entities.Skill t)
        {
            context.Skills.Update(t);// this will generate UPDATE sql query to be passed to databse via ADO.Net
            context.SaveChanges();
            return t;
        }
    }
}
