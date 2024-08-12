//FILAS
using System;
using System.Collections.Generic;

class Programa {
    static void Main() {
        // Cria uma fila de strings
        Queue<string> filaAtendimento = new Queue<string>();

        // Adiciona elementos à fila
        filaAtendimento.Enqueue("Cliente 1");
        filaAtendimento.Enqueue("Cliente 2");
        filaAtendimento.Enqueue("Cliente 3");

        // Processa o primeiro elemento da fila
        string clienteAtendido = filaAtendimento.Dequeue();
        Console.WriteLine($"{clienteAtendido} foi atendido.");

        // Verifica quem é o próximo da fila sem removê-lo
        string proximoCliente = filaAtendimento.Peek();
        Console.WriteLine($"{proximoCliente} é o próximo a ser atendido.");

        // Processa o próximo cliente
        clienteAtendido = filaAtendimento.Dequeue();
        Console.WriteLine($"{clienteAtendido} foi atendido.");

        // Itera sobre os elementos restantes na fila
        Console.WriteLine("Clientes restantes na fila:");
        foreach (string cliente in filaAtendimento) {
            Console.WriteLine(cliente);
        }
    }
}
