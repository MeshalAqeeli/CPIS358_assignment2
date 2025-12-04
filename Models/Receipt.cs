namespace ReceiptTracker.Models
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public string ProductName { get; set; }
        public string StoreName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public DateTime WarrantyEnd { get; set; }

        public Receipt()
        {
            ReceiptId = 0;
            ProductName = string.Empty;
            StoreName = string.Empty;
            PurchaseDate = DateTime.MinValue;
            Price = 0.0m;
            Description = string.Empty;
            WarrantyEnd = DateTime.MinValue;

        }

    }
}
