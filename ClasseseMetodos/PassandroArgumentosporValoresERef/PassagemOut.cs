using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PassandroArgumentosporValoresERef
{
    internal class PassagemOut
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Circulo circulo = new Circulo();

            double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);
            Console.WriteLine($"perímetro da circunferencia: {circunferencia}");
            Console.WriteLine($"área do círculo: {area}");

           for (circunferencia = 1; circunferencia <= 100; circunferencia += 10)
            {
                double r = circunferencia / (2 * Math.PI);
                double a;
                circulo.CalculaAreaPerimetro(r, out a);
                Console.WriteLine($"\nRaio: {r:F2} - Área: {a:F2}");
            }

        }
    }
    public class Circulo
    {
     public double CalculaAreaPerimetro(double raio, out double area)
        {

            area = Math.PI * Math.Pow(raio, 2);
            double perimetro = 2 * Math.PI * raio;
            return perimetro;
        }
    }
}
