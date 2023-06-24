namespace WoodWorking.Models
{
    public class AllMaterialsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ANPF { get; set; } = null!;

        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
    }
}