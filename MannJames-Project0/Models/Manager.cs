using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Manager
    {
        [Key]
        [Required]
        public int ManagerId { get; set; }
        [Required]
        [ForeignKey("FK_Manager")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee {get;set;}

        public Manager(int ManagerId, int EmployeeId)
        {
            this.ManagerId = ManagerId;
            this.EmployeeId = EmployeeId;
        }

        public Manager()
        {
            this.ManagerId = 0;
            this.EmployeeId = 0;
        }

        public override string ToString()
        {
            return $"{ManagerId} {EmployeeId}";
        }
    }
}
