using Employee_TaskCoreWebApis.Models;

namespace Employee_TaskCoreWebApis.Services
{
    public interface IEmployeeService
    {
        void AddEmployee(TblEmployees Employee);
        void UpdateEmployee(TblEmployees Employee); 
        void DeleteEmployee(int EmployeeId);
        List<TblEmployees> GetAllEmployees();
        TblEmployees GetEmployee(int empId);

    }
}
