using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface IEmployeeRepo
    {
        /// <param name="employee"></param>
        void AddEmployee(Employee employee);
        Task<List<Employee>> GetAllEmployeesAsync();
        List<Employee> GetAllEmployees();
        Task<Employee> GetEmployeeByIdAsync(int employeeId);
        Manager GetEmployeeById(int employeeId);
    }
}
