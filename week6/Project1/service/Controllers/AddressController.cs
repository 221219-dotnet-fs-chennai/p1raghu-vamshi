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
    public class AddressController : ControllerBase
    {
        ILogic2 logic2;
        public AddressController(ILogic2 logic2) => this.logic2 = logic2;
        [HttpGet("FetchAddress")]
        public IActionResult Get()
        {
            try
            {
                var Address = logic2.GetAddress();
                return Ok(Address);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Add([FromBody] Modules.Address address)
        {
            //try
            //{
            var newuser = logic2.AddAddress(address);
            return Created("Add", newuser);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] long PhoneNumber)
        {
            try
            {
                var userDel = logic2.RemoveAddress(PhoneNumber);
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
        [HttpPut("modify/{PhoneNumber}")]

        public ActionResult Put([FromRoute] long PhoneNumber, [FromBody] Address t)
        {
            return Ok(logic2.UpdateAddress(PhoneNumber, t));
        }
    }
}
