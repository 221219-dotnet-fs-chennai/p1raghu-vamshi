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
        [HttpGet("FetchEducation")]
        public IActionResult Get()
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
        public IActionResult Add([FromBody] Modules.Education education)
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
        public IActionResult Delete([FromHeader] int RollNo)
        {
            try
            {
                var userDel = logic1.RemoveEducation(RollNo);
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
        [HttpPut("modify/{RollNo}")]

        public ActionResult Put([FromRoute] int RollNo, [FromBody] Education t)
        {
            return Ok(logic1.UpdateEducationDetails(RollNo, t));
        }
    }
}
