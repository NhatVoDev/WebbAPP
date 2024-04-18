using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public int RoleNumber { get; set; }
        public string RoleName { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
