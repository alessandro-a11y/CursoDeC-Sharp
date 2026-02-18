namespace ProgramaçãoOrientadaAObjetoss
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public void Identificar()
        {
            Console.WriteLine($"{Nome} -- {Email}");

        }
    }
}