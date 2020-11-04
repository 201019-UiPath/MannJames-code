using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [ForeignKey("FK_EmpLoc")]
        public int LocationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Location Location { get; set; }
    }
}
