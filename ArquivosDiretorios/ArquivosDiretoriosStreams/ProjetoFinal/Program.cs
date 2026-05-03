using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace SerializacaoJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ListaAlunos = new List<Aluno>
            {
               new Aluno(1, "Maria", "maria@email.com", 20),
               new Aluno(2, "João", "joao@email.com", 22),
               new Aluno(3, "Ana", "ana@email.com", 21)
            };
            // 1- Serialização JSON
            string jsonString = JsonSerializer.Serialize(ListaAlunos,
                                                         new JsonSerializerOptions 
                                                         { WriteIndented = true});

            Console.WriteLine("Arquivo JSON gerado com sucesso!");

            // 2- Serialização XML

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Aluno>));

            using (StreamWriter writer = new StreamWriter("listaAlunos.xml"))
            {
                xmlSerializer.Serialize(writer, ListaAlunos);
            }
            Console.WriteLine("Arquivo XML gerado com sucesso!");

        }

        public class Aluno
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public int Age { get; set; }

            public Aluno() { }

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