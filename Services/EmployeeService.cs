using Employee_TaskCoreWebApis.Models;

namespace Employee_TaskCoreWebApis.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeDBContext _EmployeeContext;
        public EmployeeService(EmployeeDBContext employeeContext)
        {
            _EmployeeContext = employeeContext;
        }

        public void AddEmployee(TblEmployees Employee)
        {
            _EmployeeContext.Add(Employee);
            _EmployeeContext.SaveChanges();
        }

        public void DeleteEmployee(int EmployeeId)
        {
            var employee = _EmployeeContext.Employees.FirstOrDefault(e => e.EmployeeId == EmployeeId);

            if (employee != null)
            {
                _EmployeeContext.Employees.Remove(employee);
                _EmployeeContext.SaveChanges();
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }

        public List<TblEmployees> GetAllEmployees()
        {
            return _EmployeeContext.Employees.ToList();
        }

        public TblEmployees GetEmployee(int empId)
        {
            return _EmployeeContext.Find<TblEmployees>(empId);
        }

        public void UpdateEmployee(TblEmployees Employee)
        {
            _EmployeeContext.Update(Employee);
            _EmployeeContext.SaveChanges();

        }
    }
}
