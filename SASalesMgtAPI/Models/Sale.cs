using System.ComponentModel.DataAnnotations;

namespace SASalesMgtAPI.Models
{
    public class SaleTotals
    {
        public double BalanceAmount { get; set; }
        public double FinalTotal { get; set; }
    }
    public class Sale : SaleTotals
    {
        public int ID { get; set; }
        public int StatusID { get; set; }
        public string? ApprovedDate { get; set; }
        public string? SaleDate { get; set; }
        public string? CustomerName { get; set; }
        public string? CustType { get; set; }
        public string? ExtSaleID { get; set; }
        public string? Status { get; set; }
        public IList<Revision>? Revisions { get; set; }
    }
    public class SaleViewModel
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
        public string? BuyerAddress { get; set; }
        public string? ConsigneeName { get;set; }
        public int ConsigneeID { get; set; }
        public string? ConsigneeAddress {  get; set; }
        public int PriceBookID { get; set; }
        public string? CustomerPO {  get; set; }
        public string? CustomerName {  get; set; }
        public int PmtTermID { get; set; }
        public int DelTermID { get; set; }
        public int SalesPersonID { get; set; }
        public int SaleStatusID { get; set; }
        public string? SaleDate { get; set; }
        public string? SaleApprovedDate { get; set; }
        public string? SaleInvoiceDate { get; set; }
        public int StatusID { get; set; }

    }
    public class Customer
    {
        public int ID { get; set; }
        public string? CustomerName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

    }

    public class SaleOrderNew
    {
        
        public int ID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int ConsigneeID { get; set; }
        public int PriceBookID { get; set; }
        [Required]
        public int SalesPersonID { get; set; }
        [Required]
        public int StatusID { get; set; }
        [Required]
        public string? SaleDate { get; set; }
        public string? CustomerPO {  get; set; }
        public string? CustomerName { get; set; }
        public int PmtTermID { get; set; }
        public int DelTermID { get; set; } 

    }
}
