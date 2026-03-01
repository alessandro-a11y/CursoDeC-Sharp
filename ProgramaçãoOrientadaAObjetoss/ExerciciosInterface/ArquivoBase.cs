namespace ExercicioInterface
{
    // criar classe abstrata ArquivoBase e definir um método virtual Nome()
    public abstract class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Nome do arquivo");
        }
    }
}