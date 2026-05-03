//using System;
//using System.IO;
//using System.Text.Json;

//namespace SerializacaoJSON
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Aluno aluno = new Aluno(1, "Alessandro", "email@example.com", 25);

//            var caminhoArquivo = Path.Combine(
//                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
//                "aluno.json"
//            );

//            using (FileStream stream = new FileStream(
//                caminhoArquivo,
//                FileMode.Create,
//                FileAccess.Write))
//            {
//                JsonSerializer.Serialize(stream, aluno);
//            }

//            Console.WriteLine("Arquivo JSON criado com sucesso!");
//        }

//        public class Aluno
//        {
//            public int Id { get; set; }
//            public string Name { get; set; } = string.Empty;
//            public string Email { get; set; } = string.Empty;
//            public int Age { get; set; }

//            public Aluno() { }

//            public Aluno(int id, string name, string email, int age)
//            {
//                Id = id;
//                Name = name;
//                Email = email;
//                Age = age;
//            }
//        }
//    }
//}
using System;
using System.IO;
using System.Text.Json;

namespace SerializacaoJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caminhoArquivo = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "aluno.json"
            );

            using (FileStream stream = new FileStream(
                caminhoArquivo,
                FileMode.Open,
                FileAccess.Read))
            {
                Aluno? aluno = JsonSerializer.Deserialize<Aluno>(stream);

                if (aluno != null)
                {
                    Console.WriteLine($"Id: {aluno.Id}");
                    Console.WriteLine($"Nome: {aluno.Name}");
                    Console.WriteLine($"Email: {aluno.Email}");
                    Console.WriteLine($"Idade: {aluno.Age}");
                }
                else
                {
                    Console.WriteLine("Erro ao desserializar.");
                }
            }
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