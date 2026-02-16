using System;

namespace Metodos
{
    internal class Metodos
    {
        static void Main()
        {
            Aluno aluno = new Aluno();
            aluno.Consultar();
        }
    }

    public class Aluno
    {
        public string? Nome;
        public int Idade;
        public string? Sexo;
        public string? Aprovado;

        public void Consultar()
        {
            while (true)
            {
                var aluno = new Aluno();

                Console.Write("Nome: ");
                aluno.Nome = Console.ReadLine();

                Console.Write("Idade: ");
                aluno.Idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sexo: ");
                aluno.Sexo = Console.ReadLine();

                Console.Write("Aprovado? s/n: ");
                aluno.Aprovado = Console.ReadLine();

                Curso course = new Curso();
                course.Resultado(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado);

                Console.Write("\nDeseja adicionar mais algum aluno? (s/n): ");
                string resposta = Console.ReadLine();

                if (resposta.ToLower() != "s")
                {
                    break;
                }

                Console.WriteLine(); // linha em branco
            }
        }
    }

    public class Curso
    {
        public void Resultado(string nome, int idade, string sexo, string aprovado)
        {
            Console.WriteLine($"\nAluno: {nome}\nIdade: {idade}\nSexo: {sexo}");

            if (aprovado == "s" || aprovado == "S")
            {
                Console.WriteLine($"O aluno {nome} está aprovado");
            }
            else
            {
                Console.WriteLine($"O aluno {nome} está reprovado");
            }
        }
    }
}




































//using System;

//namespace Metodos
//{
//    internal class Metodos
//    {
//        static void Main(string[] args)
//        {
//            Executar();
//        }
//        public static void Executar() {
//            Estudos.MetodosComParametro("Alessandro", DateTime.Now.ToShortDateString());

//        }
//    }
//    class Estudos
//    {
//        public static void MetodosComParametro(string nome, string data)
//        {
//            Console.WriteLine(nome);
//            Console.WriteLine(data);
//        }
//    }

//}


