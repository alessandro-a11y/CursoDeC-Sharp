namespace ExercicioInterface
{
    public class SalvarJson : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando em JSON");
        }
        public override void Nome()
        {
            Console.WriteLine("Definir nome Json");
        }
        public void Compactar()
        {
            Console.WriteLine("Compactando arquivo JSON");
        }
    }
}