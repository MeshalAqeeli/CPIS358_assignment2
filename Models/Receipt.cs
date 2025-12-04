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

        }

    }
}
