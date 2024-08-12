//  ENUM (tipo de valor que define um conjunto de constantes)
using System;

// Declaração do enum fora do método
public enum DiaDaSemana {
    Domingo = 1,    // 0
    Segunda,    // 1
    Terca,      // 2
    Quarta,     // 3
    Quinta,     // 4
    Sexta,      // 5
    Sabado      // 6
}
//Por padrão, cada item começa em 0 e aumenta em 1, mas pode ser alterado

class Principal {
    static void Main() {
        // Uso do enum
        DiaDaSemana hoje = DiaDaSemana.Quarta;
        
        Console.WriteLine("Hoje é: " + hoje); // Exibe o nome do enum
        Console.WriteLine("Valor numérico de hoje: " + (int)hoje); // Exibe o valor numérico
    }
}
