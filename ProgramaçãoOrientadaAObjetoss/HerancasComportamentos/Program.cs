using System;

class Animal
{
    protected string nome;

#pragma warning disable IDE0290 // Suprimir sugestão "Usar construtor primário" localmente
    public Animal(string nome)
    {
        this.nome = nome;
    }
#pragma warning restore IDE0290

    // Tornar estático porque o método não acessa dados de instância (corrige CA1822).
    // Ainda protegido para que classes derivadas possam chamar diretamente.
    protected static void EmitirSom()
    {
        Console.WriteLine("O animal está emitindo um som...");
    }
}

class Cachorro : Animal
{
#pragma warning disable IDE0290 // Suprimir sugestão "Usar construtor primário" localmente
    public Cachorro(string nome) : base(nome) { }
#pragma warning restore IDE0290

    public void Latir()
    {
        Console.WriteLine($"{nome} está latindo!");
        EmitirSom(); // Pode acessar porque é protected (e agora é static)
    }
}

class Program
{
    static void Main()
    {
        // Simplificação do 'new' para 'target-typed new' (IDE0090).
        Cachorro dog = new("Rex");
        dog.Latir();

        // dog.nome ❌ ERRO (não pode acessar)
        // dog.EmitirSom() ❌ ERRO (não pode acessar via instância; EmitirSom é estático e protegido)
    }
}