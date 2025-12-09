namespace InvoiceExporter
{
    // Service to handle invoice operations
    public class InvoiceService
    {
        // Refactored Export method
        public void Export(BaseInvoice invoice, FileType type)
        {
            var exporter = InvoiceExporterFactory.GetExporter(type); // Get the correct exporter
            exporter.Export(invoice); // Delegate export to the exporter
        }
    }
}
