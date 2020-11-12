using System.ComponentModel.DataAnnotations;        // [Required]

namespace Commander.Models
{
    public class Command
    {

        [Key]                                       // Optional - Migrations will know this is key already
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]                            // Optional
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}

