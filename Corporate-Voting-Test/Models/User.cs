using System.ComponentModel.DataAnnotations;

namespace Corporate_Voting_Test.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [MaxLength(10)]
        public string Role { get; set; } // "Admin" or "Voter"
    }
}
