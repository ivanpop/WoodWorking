using System.ComponentModel.DataAnnotations;
using WoodWorking.Data.Models;

namespace WoodWorking.Models
{
    public class OrderViewModel
    {
        [Required]
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

        public string? ContactAddress { get; set; }

        public string? ContactPhone { get; set; }

        public string? ContactName { get; set; }

        public List<OrderedMaterial> OrderedMaterials { get; set; } = new List<OrderedMaterial>();

        public int MaterialId { get; set; }

        public IEnumerable<AllMaterialsViewModel> Materials { get; set; } = new List<AllMaterialsViewModel>();

        public IEnumerable<AllEdgesViewModel> Edges { get; set; } = new List<AllEdgesViewModel>();
    }
}