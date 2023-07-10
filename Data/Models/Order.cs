using System.ComponentModel.DataAnnotations;

namespace WoodWorking.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        [Required]
        public bool IsExpress { get; set; }

        public decimal MaterialPrice { get; set; }

        public decimal EdgePrice { get; set; }

        public decimal TotalPrice { get; set; }

        public string? ClientName { get; set; }

        public string? ClientPhone { get; set; }

        public ICollection<OrderedMaterial> OrderedMaterials { get; set; } = new List<OrderedMaterial>();
    }
}