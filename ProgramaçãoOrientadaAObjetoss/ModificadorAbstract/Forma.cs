namespace ModoficadorAbstract
{
    public abstract class Forma
    {
        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        public void Descriao()
        {
            Console.WriteLine($"Cor: {Cor}, Área: {Area}, Perímetro: {Perimetro}");

        }
    }
}