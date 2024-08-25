/*
Readonly é uma propriedade que pode ser lida, mas não pode ser modificada após a sua inicialização, exceto dentro de um construtor da classe. Isso significa que você pode atribuir um valor a uma propriedade readonly durante a construção do objeto, mas uma vez que o objeto foi criado, a propriedade se torna imutável.
*/

using System;

public class Pessoa
{
    public readonly string Nome;  // Campo readonly

    public Pessoa(string nome)
    {
        this.Nome = nome; // Atribuição permitida no construtor
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("João");
        Console.WriteLine(pessoa.Nome); // Saída: João

        // pessoa.Nome = "Maria"; // Isso causaria um erro de compilação
    }
}
/*obs.: sem READONLY, pessoa.Nome = "Maria" seria permitido*/