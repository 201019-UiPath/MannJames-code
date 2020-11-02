using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class CustomerLogin
    {
        [Key]
        [Required]
        public string Username { get; set; }
        [ForeignKey("FK_CustLogin")]
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual Customer Customer { get; set; }

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
