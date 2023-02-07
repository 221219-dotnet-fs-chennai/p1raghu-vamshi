using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using Modules;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
//using Microsoft.Data.SqlClient;
//using Microsoft.Extensions.Caching.Memory;
using Ninject.Activation.Caching;
using System.Linq.Expressions;

namespace service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControler : ControllerBase
    {
        ILogic logic;
        //  IMemoryCache cache;
        public UserControler(ILogic logic) => this.logic = logic;
        /*  {
              logic = logic;

          }*/
        [HttpGet("FetchUser")]

        public IActionResult Get()
        {
            try
            {
                var UserDetails = logic.GetUserDetails();
                return Ok(UserDetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddTrainer")]
        public IActionResult Add([FromBody] Modules.UserDetails userDetails)
        {
            try
            {
                var newuser = logic.AddUserDetails(userDetails);
                return Created("Add", newuser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] int UserId)
        {
            try
            {
                var userDel = logic.RemoveUserDetailsByUserId(UserId);
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
    }
}

