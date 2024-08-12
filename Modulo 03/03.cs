/* LIST: coleção genérica que representa uma lista de objetos fortemente tipados, acessíveis por índice. É uma das coleções mais utilizadas
*/
using System;
using System.Collections.Generic;

class Programa {
    static void Main() {
        // Cria uma lista de strings
        List<string> frutas = new List<string>();

        // Adiciona elementos à lista
        frutas.Add("Maçã");
        frutas.Add("Banana");
        frutas.Add("Laranja");

        // Acessa elementos por índice
        Console.WriteLine($"Primeira fruta: {frutas[0]}");

        // Modifica um elemento na lista
        frutas[1] = "Manga";

        // Insere um elemento em uma posição específica
        frutas.Insert(1, "Abacaxi");

        // Remove um elemento da lista
        frutas.Remove("Laranja");

        // Verifica se um elemento existe na lista
        if (frutas.Contains("Maçã")) {
            Console.WriteLine("A lista contém Maçã.");
        }

        // Itera sobre a lista
        foreach (string fruta in frutas) {
            Console.WriteLine(fruta);
        }

        // Remove um elemento por índice
        frutas.RemoveAt(2);

        // Verifica o número de elementos na lista
        Console.WriteLine($"A lista contém {frutas.Count} elementos.");
    }
}
