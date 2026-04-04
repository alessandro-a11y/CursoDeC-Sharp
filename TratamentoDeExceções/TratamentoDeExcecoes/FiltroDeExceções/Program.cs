using System;
using System.Collections.Generic;

namespace FiltroDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\nInforme o dividendo");
                int dividendo = int.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme o divisor");
                int divisor = int.Parse(Console.ReadLine());

                int resultado = dividendo / divisor;
                Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");
                Console.ReadKey();
            }
            catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                {
                    Console.WriteLine("\nSegunda amigão");
                }
            }
            catch (Exception ex) when (ex.Message.Contains("format"))
            {

                Console.WriteLine("filtro de exceção com format");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nTratando o erro em Main\n");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}