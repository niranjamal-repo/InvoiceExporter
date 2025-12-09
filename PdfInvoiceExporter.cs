using System;

namespace InvoiceExporter
{
    // Implement PDF exporter
    public class PdfInvoiceExporter : IInvoiceExporter
    {
        public void Export(BaseInvoice invoice) // Implement Export for PDF
        {
            Console.WriteLine($"Exported {invoice.GetType().Name} of {invoice.Total} to pdf"); // Output PDF export message
        }
    }
}
