namespace Exercicio2
{
    public class LivroFotos
    {
        private int numPaginas;

        // construtor padrão
        public LivroFotos()
        {
            numPaginas = 16;
        }

        // construtor com parâmetro
        public LivroFotos(int numPaginas)
        {
            this.numPaginas = numPaginas;
        }
        public int GetNumeroPaginas()
        {
            return numPaginas;
        }

    }
}