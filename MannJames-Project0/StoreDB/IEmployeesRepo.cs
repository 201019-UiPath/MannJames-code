using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreDB
{
    public interface IEmployeesRepo
    {
        void AddEmployee(Employee employee);
        Task<List<Employee>> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        Task<List<Employee>> GetEmployeesByLocation(int locId);

        void AddManager(Manager manager);
        Task<List<Manager>> GetAllManagers();
        Manager GetManagerByMId(int managerId);
        Manager GetManagerByEId(int employeeId);
    }
}
