using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializacaoBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(101, "Maria", "maria@yahoo.com", 17);

            var caminhoArquivo = @"C:\temp\aluno.bin";

            using (FileStream stream = new FileStream(caminhoArquivo,
                FileMode.Create,
                FileAccess.ReadWrite))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(stream, aluno1);
            }
        }
    }
}