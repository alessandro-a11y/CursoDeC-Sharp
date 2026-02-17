//using System;
//using System.Collections.Generic;
//using System.Text;
//using static ExercicioFinal.ListaObjetosPessoas;

//namespace ExercicioFinal
//{
//    internal partial class ListaObjetosPessoas
//    {
//        // Campo estático acessível por métodos estáticos e pela classe aninhada
//        private static List<Pessoa> pessoas = new List<Pessoa>();

//        static void Main()
//        {
//            // Inicializa a lista (já inicializada acima, mas garantir estado limpo)
//            pessoas = new List<Pessoa>();

//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine($"Digite o nome da pessoa {i + 1}:");
//                string nome = Console.ReadLine();
//                Console.WriteLine($"Digite a idade da pessoa {i + 1}:");
//                int idade = int.Parse(Console.ReadLine());
//                pessoas.Add(new Pessoa(nome, idade));
//            }

//            // Exibe a lista usando o método estático corrigido
//            Pessoa.Exibir();


//            Console.WriteLine("\nAdicionando 2 pessoas: ");

//            for(int i = 0; i < 2; i++)
//            {
//                Console.WriteLine($"\nDigite o nome da pessoa {i + 4}:");
//                string nome = Console.ReadLine();
//                Console.WriteLine($"Digite a idade da pessoa {i + 4}:");
//                int idade = int.Parse(Console.ReadLine());
//                pessoas.Add(new Pessoa(nome, idade));
//            }

//            Pessoa.Exibir();

//            pessoas.Remove(pessoas[4]);
//            Console.WriteLine("\nLucas removido");

//            Pessoa.Exibir();
//        }
//    }
//}
