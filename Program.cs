using System;
using InvoiceExporter;

// Create sample invoices
var salesInvoice = new SalesInvoice("INV-001", 1500.50m, DateTime.Now, "Acme Corp");
var service = new InvoiceService();

// Export to CSV
Console.WriteLine("--- Exporting to CSV ---");
service.Export(salesInvoice, FileType.CSV);

// Export to PDF
Console.WriteLine("\n--- Exporting to PDF ---");
service.Export(salesInvoice, FileType.PDF);

// Try unsupported format (will throw exception)
Console.WriteLine("\n--- Trying unsupported format ---");
try
{
    var exporter = InvoiceExporterFactory.GetExporter((FileType)999);
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
