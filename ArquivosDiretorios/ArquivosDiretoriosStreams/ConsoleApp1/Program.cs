using System;
using System.IO;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"d:\dados\exercicio.txt";
            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1 - Criar arquivo");
                Console.WriteLine("2 - Escrever no arquivo");
                Console.WriteLine("3 - Ler arquivo");
                Console.WriteLine("4 - Buscar texto");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Digite um número válido!");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        CriarArquivo(caminho);
                        break;

                    case 2:
                        EscreverArquivo(caminho);
                        break;

                    case 3:
                        LerArquivo(caminho);
                        break;

                    case 4:
                        BuscarTexto(caminho);
                        break;

                    case 5:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void CriarArquivo(string caminho)
        {
            try
            {
                string pasta = Path.GetDirectoryName(caminho);

                if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }

                using (FileStream fs = new FileStream(caminho, FileMode.Create))
                {
                    Console.WriteLine("Arquivo criado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        static void EscreverArquivo(string caminho)
        {
            try
            {
                if (!File.Exists(caminho))
                {
                    Console.WriteLine("Arquivo não existe. Crie primeiro.");
                    return;
                }

                Console.Write("Digite o texto: ");
                string texto = Console.ReadLine();

                using (StreamWriter sw = new StreamWriter(caminho, true))
                {
                    sw.WriteLine(texto);
                }

                Console.WriteLine("Texto adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        static void LerArquivo(string caminho)
        {
            try
            {
                if (!File.Exists(caminho))
                {
                    Console.WriteLine("Arquivo não existe.");
                    return;
                }

                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        static void BuscarTexto(string caminho)
        {
            try
            {
                if (!File.Exists(caminho))
                {
                    Console.WriteLine("Arquivo não existe.");
                    return;
                }

                Console.Write("Digite o texto para buscar: ");
                string textoBusca = Console.ReadLine();

                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    bool encontrado = false;

                    while ((linha = sr.ReadLine()) != null)
                    {
                        int posicao = linha.IndexOf(textoBusca, StringComparison.OrdinalIgnoreCase);

                        if (posicao != -1)
                        {
                            Console.WriteLine($"Encontrado na linha: {linha}");
                            Console.WriteLine($"Posição: {posicao}");
                            encontrado = true;
                            break; // primeira ocorrência
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Texto não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}