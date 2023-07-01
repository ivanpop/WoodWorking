namespace WoodWorking.Models
{
    public class AddEditMaterialViewModel
    {
        public string Name { get; set; } = null!;

        public string ANPF { get; set; } = null!;

        public string Price { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}