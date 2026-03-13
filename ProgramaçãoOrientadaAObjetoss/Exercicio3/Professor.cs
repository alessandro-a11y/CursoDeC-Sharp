namespace Exercicio3
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }
        public void Ensinar()
        {
            Console.WriteLine($"{Nome} está ensinando.");
        }
    }
}