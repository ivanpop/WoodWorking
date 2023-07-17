using System.ComponentModel.DataAnnotations;
using WoodWorking.Models;

namespace WoodWorking.Data.Models
{
    public class OrderedMaterial
    {
        [Key]
        public int OrderedMaterialsId { get; set; }

        [Required]
        public string MaterialName { get; set; } = null!;

        public decimal MaterialPrice { get; set; }

        public decimal MaterialLength { get; set; }

        public decimal MaterialHeight { get; set; }

        public decimal MaterialQty { get; set; }

        public decimal MaterialQuadrature { get; set; }

        public decimal MaterialTotalPrice { get; set; }

        public decimal MaterialEdgeH1 { get; set; }

        public decimal MaterialEdgeH1Price { get; set; }

        public decimal MaterialEdgeH2 { get; set; }

        public decimal MaterialEdgeH2Price { get; set; }

        public decimal MaterialEdgeL1 { get; set; }

        public decimal MaterialEdgeL1Price { get; set; }

        public decimal MaterialEdgeL2 { get; set; }

        public decimal MaterialEdgeL2Price { get; set; }

        public decimal MaterialEdgeTotalPrice { get; set; }
    }
}
