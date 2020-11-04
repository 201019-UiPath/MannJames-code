using Models;
using System.Collections.Generic;

namespace Repos
{
    public interface IEmployeeRepo
    {
        void AddEmployee(Employee employee);
        List<Employee> GetAllEmployeesByLocation(int locationId);
        Employee GetEmployeeById(int employeeId);
    }
}
