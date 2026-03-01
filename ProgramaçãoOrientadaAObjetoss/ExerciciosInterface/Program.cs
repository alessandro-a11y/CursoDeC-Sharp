using System;
namespace ExercicioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testar a implementação das classes SalvarXml e SalvarJson
            ISalvar salvarXml = new SalvarXml();
            salvarXml.Salvar();
            salvarXml.Compactar();
            ISalvar salvarJson = new SalvarJson();
            salvarJson.Salvar();
            salvarJson.Compactar();
        }
    }
}