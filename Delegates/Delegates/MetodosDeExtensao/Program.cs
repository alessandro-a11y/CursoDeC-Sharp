using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá, mundo!";
            string textoInvertido = texto.InverteString();
            Console.WriteLine($"Texto original: {texto}");
            Console.WriteLine($"Texto invertido: {textoInvertido}");
        }
    }
    public static class StringExtensions
    {
        public static string InverteString(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}