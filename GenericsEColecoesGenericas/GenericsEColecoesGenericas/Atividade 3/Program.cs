using System;
using System.Collections.Generic;

namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expressao = "{[(2+3)*5]}";

            bool balanceado = VerificarBalanceamento(expressao);

            Console.WriteLine(balanceado
                ? "Expressão balanceada"
                : "Expressão NÃO balanceada");

            Console.ReadKey();
        }

        static bool VerificarBalanceamento(string expressao)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char c in expressao)
            {
                // Se for abertura
                if (c == '(' || c == '{' || c == '[')
                {
                    pilha.Push(c);
                }
                // Se for fechamento
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pilha.Count == 0)
                        return false;

                    char topo = pilha.Pop();

                    if (!EhPar(topo, c))
                        return false;
                }
            }

            return pilha.Count == 0;
        }

        static bool EhPar(char aberto, char fechado)
        {
            return (aberto == '(' && fechado == ')') ||
                   (aberto == '{' && fechado == '}') ||
                   (aberto == '[' && fechado == ']');
        }
    }
}