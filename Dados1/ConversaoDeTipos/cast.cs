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
}*/

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