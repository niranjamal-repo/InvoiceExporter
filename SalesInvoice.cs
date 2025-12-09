using System;

namespace InvoiceExporter
{
    // Concrete invoice type for sales
    public class SalesInvoice : BaseInvoice
    {
        public string CustomerName { get; set; }

        public SalesInvoice(string invoiceNumber, decimal total, DateTime issueDate, string customerName)
            : base(invoiceNumber, total, issueDate)
        {
            CustomerName = customerName;
        }
    }
}
