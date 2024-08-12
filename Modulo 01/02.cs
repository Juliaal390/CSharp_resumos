//FORMATANDO SAÍDAS
using System;

class Principal{
    static void Main(){
        string nome;
        double valor = 1234.56789;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        
        Console.WriteLine("Seu nome é {0:15}", nome); //espaçamento entre 0 texto e a var
        Console.WriteLine($"Seu nome é: {nome,15}"); //mesmo efeito
        Console.WriteLine("Valor formatado: {0:F}", valor); // Exibe 1234.57
        Console.WriteLine("Valor em moeda: {0:C}", valor); // Exibe R$ 1.234,57
        Console.WriteLine("Taxa percentual: {0:P}", valor); // Exibe 12,34%
    }
}