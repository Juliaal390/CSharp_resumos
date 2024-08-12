/*
PASSAGENS DE PARAMETROS
- Por valor: não altera o valor da var original.
- Por referencia: altera o valor original. Pode ser feito ou usando num = Dobrar(num), ou
usando o operador Ref. OBS.: Quando você usa ref, o método não deve retornar um valor.

OUT: indica que o argumento a ser passado receberá um valor dentro do método. Ou seja,
é uma referência também, mas não é passado nenhum valor para o parâmetro, é apenas uma
forma de dar saída para um valor. Isto normalmente é necessário porque o return só pode
ter um valor.
*/

using System;

class Principal {
    static void Main() {
        int num = 4;
        Dobrar(ref num); // Passa a variável por referência
        Console.WriteLine(num); // Saída: 8

        //USANDO OUT
        int resultado1, resultado2;
        
        // Chama o método com out para obter dois valores
        CalcularValores(out resultado1, out resultado2);
        
        Console.WriteLine("Resultado 1: " + resultado1); // Saída: Resultado 1: 5
        Console.WriteLine("Resultado 2: " + resultado2); // Saída: Resultado 2: 10
    }
    
    static void Dobrar(ref int valor) {
        valor *= 2;
    }

    static void CalcularValores(out int valor1, out int valor2) {
        valor1 = 5;  // Inicializa o valor1
        valor2 = 10; // Inicializa o valor2
    }
}
