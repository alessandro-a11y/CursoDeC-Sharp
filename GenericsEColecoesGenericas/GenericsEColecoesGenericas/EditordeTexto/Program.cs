using System;
using System.Collections.Generic;

namespace EditordeTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EditorTexto editor = new EditorTexto();
            Console.WriteLine("\nDigitando\n");
            editor.DigitarChar('H');
            editor.DigitarChar('e');
            editor.DigitarChar('l');
            editor.DigitarChar('l');
            editor.DigitarChar('o');

            Console.WriteLine("\nFazendo o Undo\n");
            editor.Undo();
            editor.Undo();


            Console.WriteLine("\nRedigitando\n");
            editor.DigitarChar('o');
            editor.DigitarChar('o');
            editor.DigitarChar('!');
        }
    }
    public class EditorTexto
    {
        private Stack<char> undoStack = new Stack<char>();
        private string texto = "";

        public void DigitarChar(char c)
        {
            texto += c;
            undoStack.Push(c);
            Console.WriteLine($"Texto: {texto}");
        }
    
    public void Undo()
        {
            if (undoStack.Count > 0)
            {
                char ultimoChar = undoStack.Pop();
                texto = texto.Substring(0, texto.Length - 1);
                Console.WriteLine($"Texto: {texto}");
            }
        }
}   }