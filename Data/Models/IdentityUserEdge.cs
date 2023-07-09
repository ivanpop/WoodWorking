using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WoodWorking.Data.Models
{
    public class IdentityUserEdge
    {
        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Required]
        public int EdgeId { get; set; }

        [ForeignKey(nameof(EdgeId))]
        public Edge Edge { get; set; } = null!;
    }
}