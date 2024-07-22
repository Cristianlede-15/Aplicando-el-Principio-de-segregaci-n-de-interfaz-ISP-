using Aplicando_el_Principio_de_segregación_de_interfaz__ISP_.Entities;

namespace Aplicando_el_Principio_de_segregación_de_interfaz__ISP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.Name = "Documento de prueba";
            document.Description = "Este es un documento de prueba";
            SimplePrinter simplePrinter = new SimplePrinter();

            MultiFunctionPrinter multifunctionPrinter = new MultiFunctionPrinter();
        }
    }
}
