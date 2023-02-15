using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da = EntityApi;
using Modules;
using EntityApi.Entities;

namespace BusinessLogic
{
    public class SkillLogic : ISkillLogic
    {
        Validate _id;
        da.ISkillRepo<da.Entities.Skill> repo;

        public SkillLogic(Validate id, da.SkillSqlRepo _repo)
        {
            _id = id;
            repo = _repo;
        }
        public Modules.Skills AddSkills(string Email,Modules.Skills sk)
        {
            sk.userId = _id.Pid(Email);
            return Mapper.Map(repo.Add(Mapper.Map(sk)));
        }

        public IEnumerable<Skills> GetSkills()
        {
            return Mapper.Map(repo.GetSkills());
        }
        public IEnumerable<Modules.Skills> Get(string email)
        {
            int UserId = _id.Pid(email);
            return Mapper.Map(repo.Get(UserId));
        }

        public Skills RemoveSkills(string r)
        {
            int id = _id.Pid(r);
            return Mapper.Map(repo.RemoveSkills(id));
        }

        public Skills UpdateSkills(string Email, Skills r)
        {
            var skills = (from rst in repo.GetSkills()
                             where rst.UserId == r.userId
                             select rst).FirstOrDefault();
            if (skills != null)
            {
                skills.UserId = r.userId;
                skills.SkillId = r.SkillId;
                skills.SkillName = r.SkillName;
                skills = repo.UpdateSkills(skills);
            }
            return Mapper.Map(skills);
        }
    }
}
