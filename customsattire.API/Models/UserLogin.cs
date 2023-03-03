using System.ComponentModel.DataAnnotations;

namespace CustomsAttire.API.Models
{
    public class UserLogin
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string EmailAddress { get; set; }

        public UserLogin()
        {

        }
    }
}
