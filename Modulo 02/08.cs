//SELEAD
using System;

sealed class Animal {
    public void EmitirSom() {
        Console.WriteLine("O animal faz um som.");
    }
}

// Essa tentativa de herdar de 'Animal' vai resultar em um erro
// class Cachorro : Animal { 
//     // Isso geraria um erro de compilação: "cannot derive from sealed type 'Animal'"
// }

class Principal {
    static void Main() {
        Animal a = new Animal();
        a.EmitirSom(); // Saída: "O animal faz um som."
    }
}
