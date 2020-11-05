using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Manager
    {
        [Key]
        [Required]
        public int ManagerId { get; set; }
        [ForeignKey("FK_EmployeeManager")]
        [Required]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

    }
}