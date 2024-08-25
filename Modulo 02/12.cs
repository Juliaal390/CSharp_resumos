/*
indica que o construtor da classe derivada está chamando explicitamente o construtor da classe base (a classe da qual está herdando).
*/
using System;

public class ClasseBase
{
    public ClasseBase()
    {
        // Código do construtor da classe base
        Console.WriteLine("Construtor da ClasseBase");
    }
}

public class ClasseDerivada : ClasseBase
{
    public ClasseDerivada() : base()
    {
        // Código do construtor da classe derivada
        Console.WriteLine("Construtor da ClasseDerivada");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Criando uma instância de ClasseDerivada
        ClasseDerivada derivada = new ClasseDerivada();
    }
}

/*
Será printado na tela:

Construtor da ClasseBase
Construtor da ClasseDerivada
*/