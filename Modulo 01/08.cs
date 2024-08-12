/*
MÉTODOS DE ARRAY
- BinarySearch: encontra a posição de um elemento em um array. OBS.: só retorna 1 posição
- Copy e CopyTo: copia elementos de um array para outro array, a partir de uma certa posição
- GetValue: pega o valor do elemento de um array a partir do seu índice
- IndexOf e LastIndexOf: retornam o índice de um elemento no array
- Reverse: reverte um array
- SetValue: atribui um valor ao elemento do array
- Sort: ordena elementos de um array
*/
using System;

class Principal {
    static void Main() {
        //BINARYSEARCH
        int[] numeros = { 1, 3, 5, 7, 9, 11 };

        int valorProcurado = 7;
        int index = Array.BinarySearch(numeros, valorProcurado);

        if (index >= 0) {
            Console.WriteLine($"Valor {valorProcurado} encontrado na posição {index}.");
        } else {
            Console.WriteLine($"Valor {valorProcurado} não encontrado.");
        }
        
        
        //COPY
        int[] arrayOriginal = { 1, 2, 3, 4, 5 };
        int[] arrayCopia = new int[5];

        Array.Copy(arrayOriginal, arrayCopia, arrayOriginal.Length);

        Console.WriteLine("Array Original: " + string.Join(", ", arrayOriginal));
        Console.WriteLine("Array Cópia: " + string.Join(", ", arrayCopia));
        
        
        //GETVALUE E SETVALUE
        numeros.SetValue(2222, 2); //valor, indice
        Console.WriteLine("Valor no índice 2 de números: " + numeros.GetValue(2));

    }
}