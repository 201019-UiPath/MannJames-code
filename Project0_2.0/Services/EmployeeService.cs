using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repos;

namespace Services
{
    public class EmployeeService
    {
        private IEmployeeRepo repo;

        public EmployeeService(IEmployeeRepo repo)
        {
            this.repo = repo;
        }

       public  void AddEmployee(Employee employee)
        {
            repo.AddEmployee(employee);
        }
        public List<Employee> GetAllEmployeesByLocation(int locationId)
        {
            List<Employee> getAllEmployeesByLocation =
                repo.GetAllEmployeesByLocation(locationId);
            return getAllEmployeesByLocation;
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return repo.GetEmployeeById(employeeId);
        }
    }
}
