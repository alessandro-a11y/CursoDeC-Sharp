namespace ConstrutorStatic
{
    public class Pessoa
    {
        public static int IdadeMinima;
        public string Nome { get; set; } = string.Empty;
        public int idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Console.WriteLine("\nExecutando o construtor parametrizado");
            Nome = nome;
            this.idade = idade;
        }
        public Pessoa()
        { }
        static Pessoa()
        {
            Console.WriteLine("\nExecutando o construtor estático");
            Console.WriteLine("Inicializando o campo IdadeMinima");
            IdadeMinima = 18;
        }
    }
}