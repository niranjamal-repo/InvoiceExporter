using System;

namespace InvoiceExporter
{
    // Base class for invoice types
    public abstract class BaseInvoice
    {
        public string InvoiceNumber { get; set; }
        public decimal Total { get; set; }
        public DateTime IssueDate { get; set; }

        public BaseInvoice(string invoiceNumber, decimal total, DateTime issueDate)
        {
            InvoiceNumber = invoiceNumber;
            Total = total;
            IssueDate = issueDate;
        }
    }
}
