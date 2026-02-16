using System;

// Namespace do projeto (organização do código)
namespace ProjetoCadastro
{
    internal class Cadastro
    {
        static void Main(string[] args)
        {
            // Cria o objeto responsável pelo cadastro
            Cadastro cadastro = new Cadastro();

            // Solicita o nome do cliente
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            // Solicita a idade do cliente
            Console.WriteLine("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            // Solicita a renda do cliente
            Console.WriteLine("Renda: ");
            decimal renda = decimal.Parse(Console.ReadLine());

            // Cria o objeto Cliente usando os dados informados
            Cliente cliente = new Cliente(nome, idade, renda);

            // Registra o cliente (aplica regras de negócio, se houver)
            cadastro.Registrar(cliente);

            // Exibe os dados do cliente com um texto personalizado
            cadastro.ExibirDados("Dados do Cliente", cliente);
        }
    }

    // Classe que representa o cliente
    public class Cliente
    {
        // Atributos do cliente
        public string? Nome;
        public int Idade;
        public decimal Renda;

        // Construtor com parâmetros (usado quando já temos os dados)
        public Cliente(string? nome, int idade, decimal renda)
        {
            Nome = nome;
            Idade = idade;
            Renda = renda;
        }

        // Construtor vazio (permite criar o objeto sem dados iniciais)
        public Cliente()
        { }
    }

    // Classe responsável pelas operações de cadastro
    public class Cadastro
    {
        // Método que cria e retorna um cliente padrão
        public Cliente Registrar()
        {
            Cliente cliente = new();
            return cliente;
        }

        // Método que recebe um cliente já existente e aplica regras
        public Cliente Registrar(Cliente cliente)
        {
            // Altera a renda do cliente (regra de negócio)
            cliente.Renda = 0;
            return cliente;
        }

        // Exibe todos os dados do cliente
        public void ExibirDados(Cliente cliente)
        {
            Console.WriteLine($"{cliente.Nome}\n{cliente.Idade}\n{cliente.Renda.ToString("c")}");
        }

        // Sobrecarga: exibe dados com um texto adicional
        public void ExibirDados(string texto, Cliente cliente)
        {
            Console.Write($"\n{texto}\t");
            Console.Write($"{cliente.Nome} - {cliente.Renda.ToString("c")}");
        }
    }
}
