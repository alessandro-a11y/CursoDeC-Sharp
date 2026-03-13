using System;

class Program
{
    static void Main()
    {
        Forma q = new Quadrado(5);
        Forma t = new Triangulo(4, 6);
        Forma c = new Circulo(3);

        Console.WriteLine("Área do Quadrado: " + q.CalcularArea());
        Console.WriteLine("Área do Triângulo: " + t.CalcularArea());
        Console.WriteLine("Área do Círculo: " + c.CalcularArea());
    }
}

abstract class Forma
{
    public abstract double CalcularArea();
}

class Quadrado : Forma
{
    double lado;

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }
}

class Triangulo : Forma
{
    double baseTri;
    double altura;

    public Triangulo(double b, double h)
    {
        baseTri = b;
        altura = h;
    }

    public override double CalcularArea()
    {
        return (baseTri * altura) / 2;
    }
}

class Circulo : Forma
{
    double raio;

    public Circulo(double r)
    {
        raio = r;
    }

    public override double CalcularArea()
    {
        return Math.PI * raio * raio;
    }
}