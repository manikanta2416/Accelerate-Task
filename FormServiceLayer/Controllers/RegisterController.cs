using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Form_DAL_Layer;
using Form_DAL_Layer.Models;

namespace FormServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : Controller
    {
        private readonly Repository repository;
       
        public RegisterController(Repository repository)

        {
            this.repository = repository;
            

        }
        [HttpPost("addRequest")]
        public IActionResult AddCustomers(RegisterFormDetail customers)

        {
            try
            {
                bool result = repository.AddRegister(customers);

                if (result)
                {
                    return Ok("true");
                }
                else
                {
                    return BadRequest("false");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("getRequest")]
        public JsonResult GetAllRequest()
        {
            List<RegisterFormDetail> list= new List<RegisterFormDetail>();
           
            try
            {
                list = repository.GetallRequests();
            }
            catch(Exception ) 
            {
                list = null;
            }
            return Json(list);
        }
    }
}
