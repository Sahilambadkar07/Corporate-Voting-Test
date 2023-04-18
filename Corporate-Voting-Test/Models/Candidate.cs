using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Corporate_Voting_Test.Models
{
    public class Candidate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int ElectionId { get; set; }

        [ForeignKey("ElectionId")]
        public Election Election { get; set; }
    }
}
