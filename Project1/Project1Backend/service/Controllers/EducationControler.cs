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
    public class EducationControler : ControllerBase
    {
        ILogic1 logic1;
        public EducationControler(ILogic1 logic1) => this.logic1 = logic1;
        [HttpGet("FetchUser/{email}")]
        public IActionResult Get([FromRoute] string email)
        {
            try
            {
                var education = logic1.Get(email);
                if (education != null)
                {
                    return Ok(education);
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
        [HttpGet("FetchEducation")]
        public IActionResult GetEducationDetails()
        {
            try
            {
                var Education = logic1.GetEducationDetails();
                return Ok(Education);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddEducation")]
        public IActionResult Add( [FromBody] Modules.Education education)
        {
            //try
            //{
            var newuser = logic1.AddEduDetails(education);
            return Created("Add", newuser);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] string Email)
        {
            try
            {
                var userDel = logic1.RemoveEducation(Email);
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
        [HttpPut("modify/")]

        public ActionResult Put([FromRoute] string Email, [FromBody] Education t)
        {
            return Ok(logic1.UpdateEducationDetails(Email, t));
        }
    }
}
