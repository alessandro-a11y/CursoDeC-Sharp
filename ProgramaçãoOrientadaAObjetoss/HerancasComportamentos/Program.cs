using System;

class Animal
{
    protected string nome;

    public Animal(string nome)
    {
        this.nome = nome;
    }

    protected void EmitirSom()
    {
        Console.WriteLine("O animal está emitindo um som...");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }

    public void Latir()
    {
        Console.WriteLine($"{nome} está latindo!");
        EmitirSom(); // Pode acessar porque é protected
    }
}

class Program
{
    static void Main()
    {
        Cachorro dog = new Cachorro("Rex");
        dog.Latir();

        // dog.nome ❌ ERRO (não pode acessar)
        // dog.EmitirSom() ❌ ERRO (não pode acessar)
    }
}