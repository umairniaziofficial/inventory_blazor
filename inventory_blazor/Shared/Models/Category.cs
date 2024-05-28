namespace inventory_blazor.Shared.Models
{
    public class Category
    {
        public int Cid { get; set; }
        public string Category_name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
