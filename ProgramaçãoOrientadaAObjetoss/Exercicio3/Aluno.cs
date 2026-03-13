namespace Exercicio3
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }

        public void Estudar()
        {
            Console.WriteLine($"{Nome} está estudando.");
        }
    }
}