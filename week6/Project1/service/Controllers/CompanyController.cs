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
        public IActionResult Delete([FromHeader] string CompanyEmail)
        {
            try
            {
                var userDel = companylogic.RemoveCompany(CompanyEmail);
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

        public ActionResult Put([FromRoute] string CompanyEmail, [FromBody] Company t)
        {
            return Ok(companylogic.RemoveCompany(CompanyEmail));
        }
    }
}
