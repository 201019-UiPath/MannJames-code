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
        Customer GetEmployeeByLocation(int locId);
        Customer GetEmployeeByName(string firstName, string lastName);
    }
}
