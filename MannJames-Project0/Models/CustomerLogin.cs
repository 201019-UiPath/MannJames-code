using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CustomerLogin
    {
        public int CustomerId { get; set; }
        public string Password { get; set; }

        public CustomerLogin()
        {
            this.CustomerId = 0;
            this.Password = null;
        }

        public CustomerLogin(int CustomerId, string Password)
        {
            this.CustomerId = CustomerId;
            this.Password = Password;
        }
        public override string ToString()
        {
            return $"{CustomerId} {Password}";
        }
    }
}
