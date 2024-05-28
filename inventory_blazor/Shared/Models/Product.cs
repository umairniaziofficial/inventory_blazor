namespace inventory_blazor.Shared.Models
{
    public class Product
    {
        public int Pid { get; set; }
        public int Cid { get; set; }
        public int Bid { get; set; }
        public int Sid { get; set; }
        public string Pname { get; set; }
        public int PStock { get; set; }
        public decimal Price { get; set; }
        public DateTime AddedDate { get; set; }
        public string? Image { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public Store Store { get; set; }
    }
}
