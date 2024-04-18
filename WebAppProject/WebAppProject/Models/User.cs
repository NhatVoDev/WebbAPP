using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FirtsName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Image { get; set; }

        public string Country { get; set; }

        public string CICard { get; set; }

        public int UserId { get; set; }

        [ForeignKey("AccountId")]
        public Account Accounts { get; set; }
    }
}
