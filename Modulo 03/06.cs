/*Object é o tipo de dados base que pode armazenar qualquer tipo de dados,
como números, strings, instâncias de classes e muito mais.*/

using System;

class Program
{
    static void Main()
    {
        // Declarando uma variável do tipo object
        object obj;

        // Atribuindo um valor inteiro
        obj = 123;
        Console.WriteLine("Valor (int): " + (int)obj);

        // Atribuindo uma string
        obj = "Olá, Mundo!";
        Console.WriteLine("Valor (string): " + (string)obj);
        
        // Atribuindo uma instância de uma classe
        obj = new  valorClass() { Valor = 456.78m };
         valorClass detalhes = ( valorClass)obj;
        Console.WriteLine("Valor ( valorClass): " + detalhes.Valor);
    }
}

public class valorClass
{
    public decimal Valor { get; set; }
}