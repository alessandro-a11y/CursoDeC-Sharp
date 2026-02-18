using System;
namespace ProgramaçãoOrientadaAObjetoss
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "João";
            funcionario.Email = "teste@gmail.com";
            funcionario.Empresa = "Microsoft";
            funcionario.Salario = 5000;

            Console.WriteLine("---FUNCIÓNÁRIO---");
            funcionario.Identificar();
            Console.WriteLine($"Empresa: {funcionario.Empresa}");
            Console.WriteLine($"Salário: {funcionario.Empresa}");
            ;


            Aluno aluno = new Aluno();
            aluno.Nome = "Maria";
            aluno.Email = "Maria@Gmail.com";
            aluno.Curso = "Engenharia de Software";
            aluno.Nota = 10;

            Console.WriteLine("\n---ALUNO---");
            aluno.Identificar();
            Console.WriteLine($"Curso: {aluno.Curso}");
            Console.WriteLine($"Nota: {aluno.Nota}");
        }
    }
}