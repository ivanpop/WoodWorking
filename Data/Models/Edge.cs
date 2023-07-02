using System.ComponentModel.DataAnnotations;

namespace WoodWorking.Data.Models
{
    public class Edge
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Height { get; set; }

        [Required]
        public decimal Length { get; set; }

        [Required]
        public decimal Price { get; set; }

        public IEnumerable<IdentityUserEdge> UserEdges = new List<IdentityUserEdge>();
    }
}