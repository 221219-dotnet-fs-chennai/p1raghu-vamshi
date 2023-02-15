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
    public class CompanyController : ControllerBase
    {
        ICompanyLogic companylogic;
        public CompanyController(ICompanyLogic companylogic) => this.companylogic = companylogic;
        [HttpGet("FetchUser/{email}")]
        public IActionResult Get([FromRoute] string email)
        {
            try
            {
                var company = companylogic.Get(email);
                if (company != null)
                {
                    return Ok(company);
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
        [HttpGet("FetchCompany")]
        public IActionResult Get()
        {
            try
            {
                var Company = companylogic.GetCompany();
                return Ok(Company);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Add([FromBody] Modules.Company company)
        {
            //try
            //{
            var newuser = companylogic.AddCompany(company);
            return Created("Add", newuser);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([FromHeader] string Email)
        {
            try
            {
                var userDel = companylogic.RemoveCompany(Email);
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
        [HttpPut("modify/{CompanyEmail}")]

        public ActionResult Put([FromRoute] string Email, [FromBody] Company t)
        {
            return Ok(companylogic.RemoveCompany(Email));
        }
    }
}
