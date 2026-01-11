using System;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero = 5;
            Console.WriteLine(numero++);
            numero = 1;
            Console.WriteLine(++numero);
            numero = 2;
            Console.WriteLine(numero--);
            numero = 3;
            Console.WriteLine(--numero);
        } 
    }
}

// Questão 1
//string name = "Paulo";
//int age = 17;
//double note = 7.5;

//Console.WriteLine($"Aluno {name} tem {age} e nota {note}");

// Questão 2
//string name = "Paulo";
//int age = 17;
//double note = 7.5;

//Console.WriteLine($"Aluno {name}\nidade {age}\nnota {note}");

// Questão 3
//Console.WriteLine("Digite a primeira letra: ");
//string letra1 = Console.ReadLine();
//Console.WriteLine("Digite a segunda letra: ");
//string letra2 = Console.ReadLine();
//Console.WriteLine("Digite a terceira letra: ");
//string letra3 = Console.ReadLine();
//Console.WriteLine($"{letra3}, {letra2}, {letra1}");

// Questão 4
//Console.WriteLine("Digite um número: \n");
//double number1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Digite outro número: \n");
//double number2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Soma: {number1 + number2}");
//Console.WriteLine($"Subtração: {number1 - number2}");
//Console.WriteLine($"Multiplicação: {number1 * number2}");
//Console.WriteLine($"Exponenciação: {Math.Pow(number1, number2)}");
//Console.WriteLine($"Divisão inteira: {number1 / number2}");
//Console.WriteLine($"Módulo: {number1 % number2}");

// Questão 5
//double a = 1;
//double b = 12;
//double c = -13;

//double delta = Math.Pow(b, 2) - 4 * a * c;

//double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

//Console.WriteLine($"x1 = {x1}");
//Console.WriteLine($"x2 = {x2}");

// Questão 6
//Console.WriteLine("Informe o nome do usuário: \n");
//string name_user = Console.ReadLine();
//Console.WriteLine("Informe a senha: \n");
//int password = Convert.ToInt32(Console.ReadLine());

//var user = (name_user == "admin" || name_user == "Maria") && password == 123
//    ? "Acesso permitido"
//    : "Acesso negado";

//Console.WriteLine(user);

// Questão 7
//Console.Write("Digite o valor de x: ");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.Write("Digite o valor de y: ");
//int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(x % 2 == 0 ? "x é par" : "x não é par");
//Console.WriteLine(y % 2 == 0 ? "y é par" : "y não é par");

// Questão 8
//Console.Write("Digite um número inteiro x: ");
//int x = Convert.ToInt32(Console.ReadLine());

//const double pi = 3.1415;

//Console.WriteLine($"x ao quadrado = {Math.Pow(x, 2)}");
//Console.WriteLine($"x ao cubo = {Math.Pow(x, 3)}");
//Console.WriteLine($"x vezes pi = {x * pi}");
//Console.WriteLine($"2x = {2 * x}");