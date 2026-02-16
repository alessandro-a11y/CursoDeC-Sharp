namespace Exercicio
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"\nAluno: {Nome}, Nota: {Nota}");

        }
        public bool EstaAprovado()
        {
            return Nota > 8;
        }

    }
}