using System;
namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                try
                {
                    Console.WriteLine("Informe seu nome: ");
                    string nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        throw new NullReferenceException("O nome não pode ser nulo nem vazio");
                    }

                    Console.WriteLine("Informe sua idade: ");
                    if (!int.TryParse(Console.ReadLine(), out int idade))
                    {
                        throw new Exception("Idade inválida.");
                    }

                    if (idade < 0)
                    {
                        throw new ArgumentException("A idade não pode ser negativa.");
                    }

                    if (idade == 0)
                    {
                        throw new NotImplementedException("A idade ainda não foi definida.");
                    }

                    Console.WriteLine($"Nome: {nome}, Idade: {idade}");
                }
                catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Fim do programa.");
            }
    }   }
}