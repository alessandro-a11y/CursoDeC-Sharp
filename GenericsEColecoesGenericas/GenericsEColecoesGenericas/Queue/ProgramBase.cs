namespace Queue
{
    internal class ProgramBase
    {

        private static void ExibirCurso<T>(IEnumerable<T> cursos)
        {
            Console.WriteLine();
            foreach (var curso in cursos)
            {
                Console.WriteLine(curso);
            }
        }
    }
}