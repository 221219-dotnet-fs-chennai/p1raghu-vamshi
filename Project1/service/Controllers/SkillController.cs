using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using Modules;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using Ninject.Activation.Caching;
using System.Linq.Expressions;

namespace service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        ISkillLogic skilllogic;
        public SkillController(ISkillLogic skilllogic) => this.skilllogic = skilllogic;
        [HttpGet("FetchUser/{email}")]
        public IActionResult Get([FromRoute] string email)
        {
            try
            {
                var skill = skilllogic.Get(email);
                if (skill != null)
                {
                    return Ok(skill);
                }
                else
                {
                    return BadRequest("No Details found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("FetchSkills")]
        public IActionResult GetSkills()
        {
            try
            {
                var Skills = skilllogic.GetSkills();
                return Ok(Skills);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Add( string Email, [FromBody] Modules.Skills skills)
        {
            //try
            //{
            var newuser = skilllogic.AddSkills(Email,skills); 
            return Created("Add", newuser);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] string Email)
        {
            try
            {
                var userDel = skilllogic.RemoveSkills(Email);
                if (userDel != null)
                {
                    return Ok(userDel);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpPut("modify/{Email}")]

        public ActionResult Put([FromRoute] string Email, [FromBody] Skills t)
        {
            return Ok(skilllogic.UpdateSkills(Email, t));
        }
    }
}
