using System;
internal class ProgramNull
{
    static void Main(string[] args)
    {
        int? a = 30;
         if(a.HasValue)
        {
            Console.WriteLine($"O valor da váriavel é: {a.Value}");
        }else
        {
            Console.WriteLine("A variável não possui valor atribuído.");
        }
    }
}

