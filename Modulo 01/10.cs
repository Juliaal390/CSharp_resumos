/* PARAMS
 permite que um método receba um número variável de argumentos, como um array. Isso é
 útil quando você não sabe quantos parâmetros serão passados para o método ou deseja
 permitir que o método aceite qualquer número de argumentos.
*/

using System;

class Principal {
    static void Main() {
        // Chama o método com diferentes números de argumentos
        Console.WriteLine(Somar(1, 2));          // Saída: 3
        Console.WriteLine(Somar(1, 2, 3, 4));    // Saída: 10
        Console.WriteLine(Somar(10, 20, 30));    // Saída: 60
    }
    
    static int Somar(params int[] numeros) {
        int soma = 0;
        foreach (int numero in numeros) {
            soma += numero;
        }
        return soma;
    }
}

