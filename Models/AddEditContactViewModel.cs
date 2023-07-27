namespace WoodWorking.Models
{
    public class AddEditContactViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}