namespace inventory_blazor.Shared.Models
{
    public class Brand
    {
        public int Bid { get; set; }
        public string Bname { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
