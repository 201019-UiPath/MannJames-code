using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreWeb.Models
{
    public class User
    {
        public int UserId { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Must be a valid email")]
        [DisplayName("Email Address")]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Name")]
        [Required]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [Required]
        public string Password { get; set; }

        public int LocationId { get; set; }

        public UserType Type { get; set; }
        public List<Order> Orders { get; set; }
        public Location Location { get; set; }
        public Cart Cart { get; set; }
        public enum UserType
        {
            Customer,
            Manager
        }
        public User()
        {
            Cart = new Cart();
        }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}