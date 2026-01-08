/*using System;
namespace ConversaoDeTipos
{
	internal class Cast
	{
		static void Main(string[] args)
		{
			double varDouble = 12.456;
			int varInt = (int)varDouble;

			Console.WriteLine(varInt);
		}
	}
}

// conversão para string usando o método ToString()


using System;
namespace ConversaoDeTipos{
    internal class Cast
    {
		static void Main(string[] args)
		{
			int valorInt = 123;
			double valorDouble = 12.45;
			decimal valorDecimal = 12.345678m;

			string s1 = valorInt.ToString();
			string s2 = valorDouble.ToString();
			string s3 = valorDecimal.ToString();

			Console.WriteLine(s1);
			Console.WriteLine(s2);
			Console.WriteLine(s3);

			Console.ReadLine();
		}
    }
// convertendo com o metodo convert()
using System;
namespace ConversaoDeTipos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s1 = "123";
			string s2 = "12.45";
			string s3 = "12.345678";
			int valorInt = Convert.ToInt32(s1); // convertendo string para int
            double valorDouble = Convert.ToDouble(s2); // convertendo string para double
            decimal valorDecimal = Convert.ToDecimal(s3); // convertendo string para decimal
            Console.WriteLine(valorInt);
			Console.WriteLine(valorDouble);
			Console.WriteLine(valorDecimal);
            // agr confimar se houve conversão, usando o gettype
            Console.WriteLine(valorInt.GetType());
			Console.WriteLine(valorDouble.GetType());
			Console.WriteLine(valorDecimal.GetType());


            Console.ReadLine();
		}
	}
}*/