using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDB
{
    public interface IEmployeesRepo
    {
        void AddEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        Employee GetEmployeeByLocation(int locId);
        Employee GetEmployeeByName(string firstName, string lastName);
        Manager GetAllManagers();
        Manager GetManagerById(int managerId);
        Manager GetManagerByEId(int employeeId);
    }
}
