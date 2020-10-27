using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee
    {
        int EmployeeId;
        string FirstName;
        string LastName;
        int LocationId;

        public Employee(int EmployeeId, string FirstName, string LastName, int LocationId)
        {
            this.EmployeeId = EmployeeId;
            this.FirstName = FirstName; 
            this.LastName = LastName; 
            this.LocationId = LocationId;
        }

        public override string ToString()
        {
            return $"{ EmployeeId } { FirstName } { LastName } { LocationId }";
        }
    }
}
