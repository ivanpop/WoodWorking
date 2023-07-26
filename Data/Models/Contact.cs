using System.ComponentModel.DataAnnotations;

namespace WoodWorking.Data.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public string Phone { get; set; } = null!;
    }
}