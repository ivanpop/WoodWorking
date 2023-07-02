using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WoodWorking.Data.Models
{
    public class IdentityUserEdge
    {
        [Required]
        public string StoreId { get; set; } = null!;

        [ForeignKey(nameof(StoreId))]
        public IdentityUser Store { get; set; } = null!;

        [Required]
        public int EdgeId { get; set; }

        [ForeignKey(nameof(EdgeId))]
        public Edge Edge { get; set; } = null!;
    }
}