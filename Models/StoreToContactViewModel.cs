namespace WoodWorking.Models
{
    public class StoreToContactViewModel
    {
        public string StoreName { get; set; } = null!;

        public string ContactName { get; set; } = null!;

        public List<string> Stores { get; set; } = new List<string>();

        public List<string> Contacts { get; set;} = new List<string>();
    }
}