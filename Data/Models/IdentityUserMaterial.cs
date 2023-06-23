using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WoodWorking.Data.Models
{
    public class IdentityUserMaterial
    {
        [Required]
        public string StoreId { get; set; } = null!;

        [ForeignKey(nameof(StoreId))]
        public IdentityUser Store { get; set; } = null!;

        [Required]
        public int MaterialId { get; set; }

        [ForeignKey(nameof(MaterialId))]
        public Material Material { get; set; } = null!;
    }
}