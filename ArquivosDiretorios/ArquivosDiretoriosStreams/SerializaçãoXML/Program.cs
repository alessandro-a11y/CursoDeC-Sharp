using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializacaoXML
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Aluno aluno1 = new Aluno(1, "John Doe", "john.doe@example.com", 20);

            //string caminhoArquivo = @"C:\caminho\para\o\arquivo.xml";

            //XmlSerializer serializer = new XmlSerializer(typeof(Aluno));
            //using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            //{
            //    serializer.Serialize(writer, aluno1);
            //}
            string caminhoArquivo = @"C:\caminho\para\o\arquivo.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                {
                    Aluno alunoDeserializado = (Aluno)serializer.Deserialize(reader);
                    Console.WriteLine($"ID: {alunoDeserializado.Id}");
                    Console.WriteLine($"Name: {alunoDeserializado.Name}");
                    Console.WriteLine($"Email: {alunoDeserializado.Email}");
                    Console.WriteLine($"Age: {alunoDeserializado.Age}");

                }

            }
        }
    public class Aluno
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public int Age { get; set; }

            public Aluno()
            { }

            public Aluno(int id, string name, string email, int age)
            {
                Id = id;
                Name = name;
                Email = email;
                Age = age;
            }
        }
    }
}