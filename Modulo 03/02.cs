//DICTIONARY: armazena pares de chave-valor
//É possível usar LinkedList para manipular melhor o local que os elementos devem ser inseridos

using System;
using System.Collections.Generic;

class Programa {
    static void Main() {
        // Cria um novo dicionário
        Dictionary<string, int> estoque = new Dictionary<string, int>();

        // Adiciona pares de chave-valor ao dicionário
        estoque.Add("Maçã", 50);
        estoque.Add("Banana", 30);
        estoque.Add("Laranja", 20);

        // Acessa um valor usando a chave
        int quantidadeMacas = estoque["Maçã"];
        Console.WriteLine($"Quantidade de Maçãs: {quantidadeMacas}");

        // Atualiza o valor associado a uma chave
        estoque["Maçã"] = 45;
        Console.WriteLine($"Quantidade de Maçãs atualizada: {estoque["Maçã"]}");

        // Verifica se uma chave existe
        if (estoque.ContainsKey("Banana")) {
            Console.WriteLine($"Existem Bananas em estoque.");
        }

        // Remove um item do dicionário
        estoque.Remove("Laranja");

        // Itera sobre todos os pares de chave-valor no dicionário
        foreach (KeyValuePair<string, int> item in estoque) {
            Console.WriteLine($"Item: {item.Key}, Quantidade: {item.Value}");
        }
    }
}
