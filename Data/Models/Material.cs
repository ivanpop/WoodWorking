using System.ComponentModel.DataAnnotations;

namespace WoodWorking.Data.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string ANPF { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        public IEnumerable<IdentityUserOrder> UserMaterials = new List<IdentityUserOrder>();
    }
}