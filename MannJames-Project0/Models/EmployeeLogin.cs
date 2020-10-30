using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class EmployeeLogin
    {
        public int EmployeeId { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public EmployeeLogin()
        {
            this.EmployeeId = 0;
            this.Role = null;
            this.Password = null;
        }

        public EmployeeLogin(int EmployeeId, string Role, string Password)
        {
            this.EmployeeId = EmployeeId;
            this.Role = Role;
            this.Password = Password;
        }

        public override string ToString()
        {
            return $"{EmployeeId} {Role} {Password}";
        }
    }
}
