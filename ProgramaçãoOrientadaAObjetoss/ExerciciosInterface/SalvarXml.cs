namespace ExercicioInterface
{
    public class SalvarXml : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando em XML");
        }
        public override void Nome()
        {
            Console.WriteLine("Definir nome XML");
        }
        public void Compactar()
        {
            Console.WriteLine("Compactando arquivo XML");
        }
    }
}