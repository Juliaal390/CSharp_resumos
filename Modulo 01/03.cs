//CONVERTENDO VALORES
using System;

class Principal{
    static void Main(){
        // Converte string para int
        string numeroTexto = "123";
        int numero = Convert.ToInt32(numeroTexto); 
        
        Console.WriteLine(numero);
        
        
        // Converte string para int
        string numeroTexto2 = "123";
        int numero2 = int.Parse(numeroTexto2); 
        
        Console.WriteLine(numero2);
        
        
        // Converte int para string
        int n1 = 123;
        string n1texto = n1.ToString(); 
        
        Console.WriteLine(n1texto);
        
        
        // CAST: conversão explícita. Pode ocorrer perda de informações
        double num = 123.4;
        int num2;
        num2 = (int)num;
        Console.WriteLine(num2);
        
        
        // Conversão implícita
        int numeroInteiro = 123;   
        double numeroDouble = numeroInteiro;

        Console.WriteLine(numeroDouble);
    }
}