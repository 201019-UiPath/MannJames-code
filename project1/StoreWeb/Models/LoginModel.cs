using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreWeb.Models
{
    public class LoginModel
    {
        public LoginModel() { }
        public LoginModel(string username, string password)
        {
            Username = username;
            Password = password;
        }

        [DataType(DataType.Text)]
        [DisplayName("Username")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
