using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class EmployeeLogin
    {
        [Key]
        [Required]
        public string Username { get; set; }
        [Required]
        [ForeignKey("FK_EmployeeLogin")]
        public int EmployeeId { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual Employee Employee { get; set; }

        public EmployeeLogin()
        {
            this.Username = null;
            this.EmployeeId = 0;
            this.Role = null;
            this.Password = null;
        }

        public EmployeeLogin(string Username, int EmployeeId, string Role, string Password)
        {
            this.Username = Username;
            this.EmployeeId = EmployeeId;
            this.Role = Role;
            this.Password = Password;
        }

        public override string ToString()
        {
            return $"{Username} {EmployeeId} {Role} {Password}";
        }
    }
}
