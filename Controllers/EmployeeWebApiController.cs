using Employee_TaskCoreWebApis.Models;
using Employee_TaskCoreWebApis.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Employee_TaskCoreWebApis.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    public class EmployeeWebApiController : ControllerBase
    {
        IEmployeeService EmployeeService;
        public EmployeeWebApiController(IEmployeeService employeeservice)
        {
            this.EmployeeService = employeeservice;
        }

        [HttpGet]
        [Route("api/Getemployee")]
        public List<TblEmployees> GetEmployees()
        {
            try
            {
                return EmployeeService.GetAllEmployees();
            }
            catch(Exception)
            {
                throw new Exception ("Error occure  employee not show ");
            }
        }

        [HttpGet]
        [Route("api/employee/{id}")]
        public TblEmployees GetEmployee(int id)
        {
            try
            {
                return EmployeeService.GetEmployee(id);

            }
            catch(Exception)
            {
                throw new Exception("Error Occure id not find out");
            }
        }
        [HttpPost]
        [Route("api/Addemployee")]
        public string AddEmployee([FromBody] TblEmployees Employee)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    EmployeeService.AddEmployee(Employee);
                    return "Employee Added Sucessfully";
                }
                return "Failed to add employee";
            }
            catch (Exception ex)
            {
                return $"Error available :{ex.Message}";
            }
        }
        [HttpPut]
        [Route("api/Updateemployee")]
        public string UpdateEmployee([FromBody]TblEmployees Employee)
        {
            try
            {
                EmployeeService.UpdateEmployee(Employee);
                return "Employee Update Sucessfully";
            }
            catch(Exception ex)
            {
                return $"Error available:{ex.Message}";
            }
        }

        [HttpDelete]
        [Route("api/deleteemployee/{id}")]
        public string DeleteEmployeeById(int id)
        {
            try
            {
                EmployeeService.DeleteEmployee(id);
                return "Employee Delete Successfully";
            }
            catch (Exception ex)
            {
                return $"An error occurred while deleting the employee: {ex.Message}";
            }
        }
    }
}

