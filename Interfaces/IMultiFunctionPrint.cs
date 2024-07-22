using System.Reflection.Metadata;


namespace Aplicando_el_Principio_de_segregación_de_interfaz__ISP_.Interfaces
{
    public interface IMultiFunctionPrint : IBasePrint
    {
        void Scan(Document document);

    }
}
