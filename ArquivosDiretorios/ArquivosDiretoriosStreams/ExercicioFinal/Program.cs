using System;
using System.IO;
using System.Linq;

namespace SistemaArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 9)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1 - Criar diretório e arquivo");
                Console.WriteLine("2 - Copiar arquivo");
                Console.WriteLine("3 - Mover arquivo");
                Console.WriteLine("4 - Listar arquivos (com subpastas)");
                Console.WriteLine("5 - Excluir arquivo ou diretório");
                Console.WriteLine("6 - Renomear arquivo");
                Console.WriteLine("7 - Tamanho total do diretório");
                Console.WriteLine("8 - Arquivo mais recente");
                Console.WriteLine("9 - Sair");
                Console.Write("Escolha: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida.");
                    continue;
                }

                try
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite o caminho do diretório: ");
                            string dir = Console.ReadLine() ?? "";

                            if (!Directory.Exists(dir))
                                Directory.CreateDirectory(dir);

                            Console.Write("Digite o nome do arquivo: ");
                            string nomeArquivo = Console.ReadLine() ?? "";

                            string caminhoArquivo = Path.Combine(dir, nomeArquivo);

                            File.WriteAllText(caminhoArquivo, "Arquivo criado!");
                            Console.WriteLine("Diretório e arquivo criados.");
                            break;

                        case 2:
                            Console.Write("Origem: ");
                            string origem = Console.ReadLine() ?? "";

                            Console.Write("Destino: ");
                            string destino = Console.ReadLine() ?? "";

                            File.Copy(origem, destino, true);
                            Console.WriteLine("Arquivo copiado.");
                            break;

                        case 3:
                            Console.Write("Origem: ");
                            string origemMove = Console.ReadLine() ?? "";

                            Console.Write("Destino: ");
                            string destinoMove = Console.ReadLine() ?? "";

                            File.Move(origemMove, destinoMove, true);
                            Console.WriteLine("Arquivo movido.");
                            break;

                        case 4:
                            Console.Write("Diretório: ");
                            string caminho = Console.ReadLine() ?? "";

                            DirectoryInfo di = new DirectoryInfo(caminho);

                            foreach (var file in di.GetFiles("*", SearchOption.AllDirectories))
                            {
                                Console.WriteLine(Path.GetFileName(file.FullName));
                            }
                            break;

                        case 5:
                            Console.Write("Digite o caminho: ");
                            string caminhoExcluir = Console.ReadLine() ?? "";

                            if (File.Exists(caminhoExcluir))
                            {
                                File.Delete(caminhoExcluir);
                                Console.WriteLine("Arquivo excluído.");
                            }
                            else if (Directory.Exists(caminhoExcluir))
                            {
                                Directory.Delete(caminhoExcluir, true);
                                Console.WriteLine("Diretório excluído.");
                            }
                            else
                            {
                                Console.WriteLine("Não encontrado.");
                            }
                            break;

                        case 6:
                            Console.Write("Caminho do arquivo: ");
                            string caminhoRename = Console.ReadLine() ?? "";

                            Console.Write("Novo nome: ");
                            string novoNome = Console.ReadLine() ?? "";

                            string pasta = Path.GetDirectoryName(caminhoRename) ?? "";
                            string novoCaminho = Path.Combine(pasta, novoNome);

                            File.Move(caminhoRename, novoCaminho);
                            Console.WriteLine("Arquivo renomeado.");
                            break;

                        case 7:
                            Console.Write("Diretório: ");
                            string dirSize = Console.ReadLine() ?? "";

                            long tamanho = Directory
                                .GetFiles(dirSize, "*", SearchOption.AllDirectories)
                                .Sum(file => new FileInfo(file).Length);

                            Console.WriteLine($"Tamanho total: {tamanho} bytes");
                            break;

                        case 8:
                            Console.Write("Diretório: ");
                            string dirRecent = Console.ReadLine() ?? "";

                            var arquivos = new DirectoryInfo(dirRecent)
                                .GetFiles()
                                .OrderByDescending(f => f.LastWriteTime)
                                .FirstOrDefault();

                            if (arquivos != null)
                                Console.WriteLine($"Mais recente: {arquivos.Name}");
                            else
                                Console.WriteLine("Nenhum arquivo encontrado.");
                            break;

                        case 9:
                            Console.WriteLine("Saindo...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }
    }
}