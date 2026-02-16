using System;
namespace ParametrosOpcionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.ExibirInfo(ano: 2020, potencia: 150);
        }
    }
    public class Carro
    {
        public string Modelo;
        public string Montadora;
        public string Marca;
        public int Potencia;
        public int Ano;

        public void ExibirInfo(string modelo = "Modelo não informado", string montadora = "Montadora não informada", string marca = "Marca não informada", int potencia = 0, int ano = 0)
        {
            Console.WriteLine($"Modelo: {modelo}\nMontadora: {montadora}\nMarca: {marca}\nPotência: {potencia}cv\nAno: {ano}");
        }

    }
}
























//using System;
//namespace ParametrosOpcionais
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Email email = new Email();
//            email.Enviar("figueiredoalessandro73@gmail.com");
//        }
//    }
//    public class Email
//    {
//        public void Enviar(string destino, string titulo = "Reunião", string assunto = "avalição técnica")
//        {
//            Console.WriteLine($"{destino}\t{titulo}\t {assunto}");
//        }
//    }
//}