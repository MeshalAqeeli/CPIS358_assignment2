namespace ReceiptTracker.Models
{
    public class Receipt
    {
        public int receiptId { get; set; }
        public string SroductName { get; set; }
        public string StoreName { get; set; }
        public DateTime purchaseDate { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }

        public int warrantyEnd { get; set; }

        public Receipt()
        {

        }

    }
}
