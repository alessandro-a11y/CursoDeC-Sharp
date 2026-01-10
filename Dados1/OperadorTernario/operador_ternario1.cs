namespace OperadorTernario
{
    internal class operador_ternario1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de x: \n");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de y: \n");
            int y = Convert.ToInt32(Console.ReadLine());

            string result = x > y ? "X é maior que Y" :
                            x < y ? "X é menor que Y" :
                            x == y ? "X é igual a Y" : "Sem resultado";
            Console.WriteLine(result);
        }
    }
}
