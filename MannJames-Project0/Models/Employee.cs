using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId;

        public string FirstName;
        public string LastName;
        public int LocationId;
        public virtual Location Location { get; set; }

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
