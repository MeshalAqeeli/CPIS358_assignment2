namespace ReceiptTracker.Models
{
    public class Receipt
    {
        public int receiptId { get; set; }
        public string productName { get; set; }
        public string storeName { get; set; }
        public DateTime purchaseDate { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }

        public int warrantyEnd { get; set; }

        public Receipt()
        {

        }

    }
}
