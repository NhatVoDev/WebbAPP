using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public int RoleNumber { get; set; }

        [ForeignKey("RoleNumber")]
        public Role Role { get; set; }
        public User? User { get; set; }

    }

    public class Login
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
