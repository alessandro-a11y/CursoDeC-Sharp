/* agora, vamos aprender a mexer com nullable types np C#
using System;
using System.Threading.Channels;
internal class ProgramNull
{
    private static void Main()
    {
        // Declarando uma variável nullable do tipo int
        int? num1 = null;
        // adiconar valor a variavel nula
         num1 = 42;
        // Verificando se a variável tem um valor e o tipo dela
        Console.WriteLine(num1.GetType());
        // int? -> pode ser null
        // int  -> não pode ser null
        // trate o null antes de atribuir


    }
}*/