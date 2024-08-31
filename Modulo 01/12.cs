// PARÂMETROS OPCIONAIS: são definidos ao atribuir um valor padrão a um parâmetro
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        ExemploMetodo("Olá", 3); //3 pode ser omitido, pois foi atribuido o valor padrão 1
    }
    public static void ExemploMetodo(string mensagem, int quantidade = 1)
    {
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine(mensagem);
        }
    }
}

/*
Argumentos nomeados: especificam explicitamente qual parâmetro está recebendo valor
ExemploMetodo("Olá", repetir: true);
*/