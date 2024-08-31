using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingExample.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //attribute routing. defining the uri by us only
        [Route("Emp/All")]
        [Route("GetAllEmployees")] //can give multiple url for a particular action method using attribute routing
        [HttpGet]
        public string GetAllEmployee()
        {
            return "Invoking GetAllEmployee method";
        }

        //attribute routing. defining the uri by us only
        [Route("Emp/ById/{Id}")]
        [HttpGet]
        public string GetEmployeeById(int Id)
        {
            return "Invoking GetEmployeeById method";
        }

        //http verb attribute routing. 
        [HttpGet("api/Employee/{Name}")]
        public string GetEmployeeByName()
        {
            return "Invoking GetEmployeeByName method";
        }

        [HttpGet("api/Employee/{Name}")]
        public string GetEmployeeName()
        {
            return "Invoking GetEmployeeByName method";
        }
    }
}
