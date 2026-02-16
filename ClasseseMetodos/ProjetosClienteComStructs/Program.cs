using System;
namespace ProjetosClienteComStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(
                Nome: "Alessandro",
                Email: "teste@gmail.com",
                idade: 15
            );

            cliente.ExibirInfo(
                nome: cliente.Nome,
                email: cliente.Email,
                idade: cliente.Idade
                );
            cliente.ExibirInfo(
                nome: cliente.Nome,
                email: cliente.Email
                );

        }
    }
    public struct Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        private int _idade;
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 18)
                    _idade = 16;
                else
                    _idade = value;
            }
        }

        public Cliente(string  Nome, string Email, int idade)
        {
            this.Nome = Nome;
            this.Email = Email;
            _idade = idade < 18 ? 16 : idade;
        }

        public void ExibirInfo(string nome, string email, int idade = 16)
        {
            Console.WriteLine($"Nome: {nome}\nEmail: {email}\nIdade: {idade}");
        }
    }
}
