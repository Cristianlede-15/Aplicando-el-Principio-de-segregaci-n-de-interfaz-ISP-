using Aplicando_el_Principio_de_segregación_de_interfaz__ISP_.Interfaces;

namespace Aplicando_el_Principio_de_segregación_de_interfaz__ISP_.Entities
{
    public class SimplePrinter : IBasePrint
    { 
        public void Print(System.Reflection.Metadata.Document document)
        {
            Console.WriteLine("Imprimiendo: " + document.Name);
        }
    }
}
