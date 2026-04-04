using System;
using System.Collections.Generic;

namespace LancamentosDeExececoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                A.ProcessarA();
            }
            catch (Exception ex)
            {

                Console.WriteLine("\nTratando o erro em Main\n");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }

    class A
    {
        public static void ProcessarA()
        {
            try
            {
                B.ProcessarB();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro em A", ex);
            }
        }
    }
    class B
    {
        public static void ProcessarB()
        {
            try
            {
                C.ProcessarC();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro em B", ex);

            }
        }
        class C
        {
            public static void ProcessarC()
            {
                throw new Exception("Ocorreu um erro em C");
            }
        }
    }
}
