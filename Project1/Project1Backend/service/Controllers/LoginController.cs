using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using Modules;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using Ninject.Activation.Caching;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
       BusinessLogic. Validation _v;
        ILogic _logic;
        public LoginController(BusinessLogic. Validation v, ILogic logic)
        {
            _v = v;
            _logic = logic;

        }
        /*[HttpPost("signUp")]
        public ActionResult Post(string Email,Modules.UserDetails userDetails)
        {
            try
            {
                if (_v.isEmailPresent(userDetails.Email) == false)
                {
                    return Ok(_logic.AddUserDetails(Email,userDetails));
                }
                else
                {
                    return BadRequest("Email already exists,please sign in");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ", Please try again");
            }
        }*/
        [HttpGet("SignIn")]
        public ActionResult SignIn(string Email, string Password)
        {
            if (_v.isEmailPresent(Email) == true)
            {
                if (_v.signIn(Email, Password))
                {
                    return Ok("Successful login");
                }
                else
                {
                    return BadRequest("Wrong passowrd");
                }
            }
            else
            {
                return BadRequest("Email does not exists,please sign up");
            }
        }
    }
}
