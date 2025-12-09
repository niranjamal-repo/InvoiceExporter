namespace InvoiceExporter
{
    // Define an interface for invoice exporters
    public interface IInvoiceExporter
    {
        void Export(BaseInvoice invoice); // Export method to be implemented by concrete classes
    }
}
