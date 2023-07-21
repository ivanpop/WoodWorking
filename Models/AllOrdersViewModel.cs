namespace WoodWorking.Models
{
    public class AllOrdersViewModel
    {
        public int Id { get; set; }

        public string? ClientName { get; set; }

        public string? ClientPhone { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsExpress { get; set; }

        public decimal MaterialPrice { get; set; }

        public decimal EdgePrice { get; set; }

        public decimal TotalPrice { get; set; }
    }
}