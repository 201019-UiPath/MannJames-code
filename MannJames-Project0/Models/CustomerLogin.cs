using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class CustomerLogin
    {
        [Key]
        public string Username { get; set; }
        public int CustomerId { get; set; }
        public string Password { get; set; }

        public CustomerLogin()
        {
            this.Username = null;
            this.CustomerId = 0;
            this.Password = null;
        }

        public CustomerLogin(string Username, int CustomerId, string Password)
        {
            this.Username = Username;
            this.CustomerId = CustomerId;
            this.Password = Password;
        }
        public override string ToString()
        {
            return $"{Username} {CustomerId} {Password}";
        }
    }
}
