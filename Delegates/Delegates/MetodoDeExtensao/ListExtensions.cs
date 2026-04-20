namespace MetodoDeExtensao
{
    public static class ListExtensions
    {
        public static int SomarImpares(this List<int> lista)
        {
            int soma = 0;
            foreach (var numero in lista)
            {
                if (numero % 2 != 0)
                {
                    soma += numero;
                }
            }
            return soma;
        }
    }
}
