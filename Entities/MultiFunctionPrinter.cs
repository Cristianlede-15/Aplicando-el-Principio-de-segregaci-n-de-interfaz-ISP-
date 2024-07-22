using Aplicando_el_Principio_de_segregación_de_interfaz__ISP_.Interfaces;

namespace Aplicando_el_Principio_de_segregación_de_interfaz__ISP_.Entities
{
    public class MultiFunctionPrinter : IMultiFunctionPrint
    {
        public void Print(System.Reflection.Metadata.Document document)
        {
            Console.WriteLine("Imprimiendo: " + document.Name);
        }

        public void Scan(System.Reflection.Metadata.Document document)
        {
            Console.WriteLine("Escaneando: " + document.Name);
        }
    }
}
