namespace HerançaXComposição
{
    public class Animal
    {
        public int idade { get; set; }
        public void Comer()
        {
            Console.WriteLine("Comendo...");
        }
        public void Dormir()
        {
            Console.WriteLine("Dormindo...");
        }
    }
}