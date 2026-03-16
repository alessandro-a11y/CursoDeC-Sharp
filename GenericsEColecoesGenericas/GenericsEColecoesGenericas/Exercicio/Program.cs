using System;
using System.Collections;
using System.Collections.Generic;
namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           ExercicioArrayEGenerics<string> exercicio = new ExercicioArrayEGenerics<string>();
            exercicio.AdicionarElementos("Elemento 1");
            exercicio.AdicionarElementos("Elemento 2");
            exercicio.AdicionarElementos("Elemento 3");
            exercicio.AdicionarElementos("Elemento 4");
            exercicio.AdicionarElementos("Elemento 5");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(exercicio[i]);
            }
        }
    }

    public class ExercicioArrayEGenerics<T>
    {
        T[] obj = new T[5];
        int contador = 0;

        public void AdicionarElementos(T item)
        {
            if (contador < obj.Length)
            {
                obj[contador] = item;
            }
            contador++; 
        }
        public T this[int index]
        {
            get
            {
                return obj[index];
            }
            set
            {
                obj[index] = value;
            }
        }
    }
}