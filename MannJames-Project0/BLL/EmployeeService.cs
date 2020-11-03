using Models;
using StoreDB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class EmployeeService
    {
        #region Employee
        private IEmployeesRepo empRepo;
        public EmployeeService(IEmployeesRepo empRepo)
        {
            this.empRepo = empRepo;
        }
        public void AddEmployee(Employee employee)
        {
            empRepo.AddEmployee(employee);
        }
        public List<Employee> GetAllEmployees()
        {
            Task<List<Employee>> getEmployeesTask = empRepo
                .GetAllEmployees();
            return getEmployeesTask.Result;
        }
        public Employee GetEmployeeById(int employeeId)
        {
            Employee resultEmployee = empRepo
                .GetEmployeeById(employeeId);
            return resultEmployee;
        }
        public List<Employee> GetEmployeesByLocation(int locId)
        {
            Task<List<Employee>> getEmployeesTask = empRepo
                .GetEmployeesByLocation(locId);
            return getEmployeesTask.Result;
        }
        #endregion

        #region Manager
        public void AddManager(Manager manager)
        {
            empRepo.AddManager(manager);
        }
        public List<Manager> GetAllManagers()
        {
            Task<List<Manager>> getEmployeesTask = empRepo
                    .GetAllManagers();
            return getEmployeesTask.Result;
        }
        public Manager GetManagerByMId(int managerId)
        {
            Manager resultEmployee = empRepo
                .GetManagerByMId(managerId);
            return resultEmployee;
        }
        public Manager GetManagerByEId(int employeeId)
        {
            Manager resultEmployee = empRepo
                .GetManagerByEId(employeeId);
            return resultEmployee;
        }
        #endregion

        #region Inventory
        #endregion

        #region Location
        #endregion

        #region Order
        #endregion
    }
}
