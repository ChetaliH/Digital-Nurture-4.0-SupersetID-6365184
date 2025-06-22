// See https://aka.ms/new-console-template for more information
namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Test test = new Test();
        DocumentType document1 = test.GetDocumentType("PDF");
        Console.WriteLine(document1.saveDocument());

        DocumentType document2 = test.GetDocumentType("Word");
        Console.WriteLine(document2.saveDocument());

        DocumentType document3 = test.GetDocumentType("Excel");
        Console.WriteLine(document3.saveDocument());
    }
}

//Interface for different document types
interface DocumentType
{
    string saveDocument();
}
//Concrete classes for each document type
class WordDocument : DocumentType
{
    public string saveDocument()
    {
        return "Word Document Saved!";
    }
}

class PdfDocument : DocumentType
{
    public string saveDocument()
    {
        return "PDF Document Saved!";
    }
}

class ExcelDocument : DocumentType
{
    public string saveDocument()
    {
        return "Excel Document Saved!";
    }
}

//Factory method
interface DocumentFactory
{
    DocumentType createDocument();
}
//Concrete factory classes
class WordDocumentFactory : DocumentFactory
{
    public DocumentType createDocument()
    {
        return new WordDocument();
    }
}

class PdfDocumentFactory : DocumentFactory
{
    public DocumentType createDocument()
    {
        return new PdfDocument();
    }
}

class ExcelDocumentFactory : DocumentFactory
{
    public DocumentType createDocument()
    {
        return new ExcelDocument();
    }
}
//Test class for testing the factory method
class Test
{
    public DocumentType GetDocumentType(string type)
    {
        DocumentFactory doc;
        switch (type)
        {
            case "Excel":
                doc = new ExcelDocumentFactory();
                break;
            case "PDF":
                doc = new PdfDocumentFactory();
                break;
            default:
                doc = new WordDocumentFactory();
                break;
        }
        return doc.createDocument();
    }
}