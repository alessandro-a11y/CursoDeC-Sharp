using System;

namespace ClasseArray
{
    internal class MediadosAlunos
    {
        static void Main()
        {
            // criar arrays
            string[] nomes = new string[5];
            double[] notas = new double[5];


            // usando laço for
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Informe o nome do aluno (id = {i}): ");
                nomes[i] = Console.ReadLine();
            }
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Informe a nota do aluno {nomes[i]}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            // mostrando os valores com foreach
            foreach (double nota in notas)
            {
                Console.WriteLine($"Nota: {nota}");
            }
            foreach(string nome in nomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }
            // fazendo somatório e média
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            double media = soma / notas.Length;
            Console.WriteLine($"Média da turma: {media}");
        }
    }
}
//string[] alunos = new string[5];
//double[] notas = new double[5];

//// Coletando os nomes dos alunos
//for (int i = 0; i < alunos.Length; i++)
//{
//    Console.WriteLine($"Digite o nome do aluno {i + 1}: ");
//    alunos[i] = Console.ReadLine();
//}

//// Coletando as notas dos alunos
//for (int i = 0; i < notas.Length; i++)
//{
//    Console.WriteLine($"Digite a nota do aluno {i + 1}: ");
//    notas[i] = Convert.ToDouble(Console.ReadLine());
//}

//// Calculando a soma das notas
//double soma = 0;
//for (int i = 0; i < notas.Length; i++)
//{
//    soma += notas[i];
//}

//// Calculando a média
//double media = soma / notas.Length;

//// Exibindo os resultados
//Console.WriteLine("\nRelatório dos alunos e suas notas:");
//for (int i = 0; i < alunos.Length; i++)
//{
//    Console.WriteLine($"Aluno: {alunos[i]} \t Nota: {notas[i]}");
//}

//// Exibindo a média final
//Console.WriteLine($"\nMédia geral dos alunos: {media}");