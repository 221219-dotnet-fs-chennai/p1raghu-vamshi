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
        [HttpGet("FetchUser/{email}")]
        public IActionResult Get([FromRoute] string email)
        {
            try
            {
                var address = logic2.Get(email);
                if (address != null)
                {
                    return Ok(address);
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

        [HttpGet("FetchAddress")]
        public IActionResult GetAddress()
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
        public IActionResult Delete([FromHeader] string Email)
        {
            try
            {
                var userDel = logic2.RemoveAddress(Email);
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

        public ActionResult Put([FromRoute] string Email, [FromBody] Address t)
        {
            return Ok(logic2.UpdateAddress(Email, t));
        }
    }
}
