using System;

namespace InvoiceExporter
{
    // Implement CSV exporter
    public class CsvInvoiceExporter : IInvoiceExporter
    {
        public void Export(BaseInvoice invoice) // Implement Export for CSV
        {
            Console.WriteLine($"Exported {invoice.GetType().Name} of {invoice.Total} to csv"); // Output CSV export message
        }
    }
}
