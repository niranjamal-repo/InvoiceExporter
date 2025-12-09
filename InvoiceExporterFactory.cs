using System;

namespace InvoiceExporter
{
    // Factory to get the correct exporter
    public static class InvoiceExporterFactory
    {
        public static IInvoiceExporter GetExporter(FileType type) // Return exporter based on file type
        {
            return type switch // Use switch expression for clarity
            {
                FileType.CSV => new CsvInvoiceExporter(), // Return CSV exporter
                FileType.PDF => new PdfInvoiceExporter(), // Return PDF exporter
                _ => throw new NotSupportedException($"File type {type} is not supported") // Handle unsupported types
            };
        }
    }
}
