using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class EmployeeLogin
    {
        [Key]
        public string Username { get; set; }
        public int EmployeeId { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

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
