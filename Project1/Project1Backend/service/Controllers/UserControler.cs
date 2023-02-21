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
using EntityApi.Entities;

namespace service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControler : ControllerBase
    {
        ILogic logic;
        //  IMemoryCache cache;
        public UserControler(ILogic logic) => this.logic = logic;
    
        [HttpGet("FetchUser/{email}")]
        public IActionResult Get([FromRoute] string email)
        {
            try
            {
                var userDetails = logic.Get(email);
                if (userDetails != null)
                {
                    return Ok(userDetails);
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
        [HttpGet("FetchUser")]

        public IActionResult GetUserDetails()
        {
            try
            {
                var UserDetails = logic.GetUserDetails();
                if (UserDetails != null)
                {
                    return Ok(UserDetails);
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
        [HttpPost("AddTrainer")]
        public IActionResult Add([FromBody] Modules.UserDetails userDetails)
        {
           // try
           //{
            var newuser = logic.AddUserDetails(userDetails);
            return Created("Add", newuser);
           // }
           // catch (Exception ex)
           // {
           //     return BadRequest(ex.Message);
           // }
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] string Email)
        {
            try
            {
                var userDel = logic.RemoveUserDetailsByUserId(Email);
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
        [HttpPut("modify")]
        
        public ActionResult Put([FromQuery] string Email, [FromBody] Modules.UserDetails t)
        {
            return Ok(logic.UpdateUserDetails(Email, t));
        }
    }
}

