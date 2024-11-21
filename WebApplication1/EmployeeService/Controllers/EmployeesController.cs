using EmployeeService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeDataAccess dal;
        public EmployeesController(IEmployeeDataAccess dal)
        {
            this.dal = dal;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        [Route("GetEmps")]
        public IEnumerable<Employee> Get()
        {


            return dal.GetAll();
        }

        // GET api/<EmployeesController>/5
        [HttpGet]
        [Route("GetEmpById/{id}")]
        public Employee Get(int id)
        {
            return dal.Get(id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        [Route("AddEmp")]
        public void Post([FromBody] Employee emp)
        {
            dal.AddEmployee(emp);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut]
        [Route("UpdateEmp/{id}")]
        public void Put(int id, [FromBody] Employee emp)
        {
            dal.UpdateEmployee(emp);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dal.DeleteEmployee(id);
        }

        //[HttpGet]
        //[Route("Divide/{a}/{b}")]
        //[AllowAnonymous]
        //public int Divide(int a ,int b)
        //{
        //    return a / b;
        //}

        //[HttpGet("{a}/{b}")]
        //public int AddNumbers(int a,int b)
        //{
        //    return a + b;
        //}
    }
}
