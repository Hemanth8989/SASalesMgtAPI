namespace SASalesMgtAPI.Models
{
    public class Revision
    {
        public int ID { get; set; }
        public string? VisitName { get; set; }
        public string? Status { get; set; }
        public string? CreateDate { get; set; }
        public string? AppInvoiceDate { get; set; }
        public string? SaleInvoiceDate { get; set; }
        public string? SaleDate { get; set; }
        public double DiscountAmt { get; set; }
        public double FinalAmt { get; set; }
        public bool IsActive { get; set; }
    }
}
