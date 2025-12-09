# Invoice Exporter

A C# console application demonstrating the **Factory Pattern** and **Interface-based design** for exporting invoices in multiple formats.

## Project Overview

This project implements an invoice exporter system that supports:
- **CSV Export**: Export invoices to CSV format
- **PDF Export**: Export invoices to PDF format

The application uses the **Factory Pattern** to dynamically select the appropriate exporter based on the desired file type, promoting clean, maintainable, and extensible code.

## Technology Stack

- **C# Version**: Latest (C# 12.0)
- **.NET Version**: .NET 8.0

## Project Structure

```
InvoiceExporter/
├── BaseInvoice.cs              # Abstract base class for all invoice types
├── SalesInvoice.cs             # Concrete implementation of sales invoices
├── FileType.cs                 # Enum for supported export formats
├── IInvoiceExporter.cs         # Interface defining the export contract
├── CsvInvoiceExporter.cs       # CSV exporter implementation
├── PdfInvoiceExporter.cs       # PDF exporter implementation
├── InvoiceExporterFactory.cs   # Factory class for creating exporters
├── InvoiceService.cs           # Service layer for invoice operations
├── Program.cs                  # Main entry point
└── InvoiceExporter.csproj      # Project file
```

## Key Components

### IInvoiceExporter Interface
Defines the contract for all exporters with a single `Export` method:
```csharp
public interface IInvoiceExporter
{
    void Export(BaseInvoice invoice);
}
```

### Factory Pattern
The `InvoiceExporterFactory` class provides a centralized way to create the appropriate exporter:
```csharp
public static class InvoiceExporterFactory
{
    public static IInvoiceExporter GetExporter(FileType type)
    {
        return type switch
        {
            FileType.CSV => new CsvInvoiceExporter(),
            FileType.PDF => new PdfInvoiceExporter(),
            _ => throw new NotSupportedException($"File type {type} is not supported")
        };
    }
}
```

## Usage

```csharp
// Create an invoice
var salesInvoice = new SalesInvoice("INV-001", 1500.50m, DateTime.Now, "Acme Corp");

// Create the service
var service = new InvoiceService();

// Export to CSV
service.Export(salesInvoice, FileType.CSV);

// Export to PDF
service.Export(salesInvoice, FileType.PDF);
```

## Building and Running

### Prerequisites
- .NET 8.0 SDK installed

### Build
```bash
dotnet build
```

### Run
```bash
dotnet run
```

## Design Patterns Used

1. **Factory Pattern**: `InvoiceExporterFactory` abstracts the creation of exporter objects
2. **Strategy Pattern**: Each exporter implements a different export strategy
3. **Dependency Inversion**: Code depends on the `IInvoiceExporter` interface, not concrete classes

## Features

- ✅ Support for multiple export formats (CSV, PDF)
- ✅ Extensible architecture for adding new export formats
- ✅ Clean separation of concerns
- ✅ Exception handling for unsupported file types
- ✅ Type-safe factory pattern with switch expressions

## Future Enhancements

- Add actual CSV file writing implementation
- Add actual PDF file generation (using a library like iTextSharp)
- Implement async export methods
- Add logging and error handling
- Support for batch exports
