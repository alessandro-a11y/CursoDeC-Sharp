using System;

namespace Exercicio1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Escreva um program onde o usuário  é solicitado a informar um valor via teclado e armazenar o valor na 
                 variável entrada do tipo string onde tem que verificar 3 condições diferentes:
             */
            try
            {
                Console.WriteLine("Insira uma palavra: ");
                string entrada = Console.ReadLine();

                if (entrada == null)
                {
                    throw new ArgumentNullException( "A entrada não pode ser nula.");
                }
                if (entrada == "")
                {
                    throw new ArgumentException("A entrada não pode ser vazia.");
                }


                Console.WriteLine($"Entrada válida: {entrada}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("fim do programa");
            }
        }
    }
}