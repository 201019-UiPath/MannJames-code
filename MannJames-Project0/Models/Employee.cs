using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeId;
        [Required]
        public string FirstName;
        [Required]
        public string LastName;
        [Required]
        [ForeignKey("FK_Employee")]
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
