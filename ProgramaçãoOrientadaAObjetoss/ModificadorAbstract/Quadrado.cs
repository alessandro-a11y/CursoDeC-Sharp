namespace ModoficadorAbstract
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override void CalcularArea()
        {
            Area = Lado * Lado;
            Console.WriteLine($"Valor da Area: {Area}");
        }
        public override void CalcularPerimetro()
        {
            Perimetro = 4 * Lado;
            Console.WriteLine($"Valor do Perimetro: {Perimetro}");
        }
    }
}