//MÉTODOS VIRTUAIS: que podem ser sobrescritos em uma classe derivada

using System;

class Animal {
    // Método virtual na classe base
    public virtual void EmitirSom() {
        Console.WriteLine("O animal faz um som.");
    }
}

class Cachorro : Animal {
    // Método sobrescrito na classe derivada
    public override void EmitirSom() {
        Console.WriteLine("O cachorro late.");
    }
}

class Gato : Animal {
    // Método sobrescrito na classe derivada
    public override void EmitirSom() {
        Console.WriteLine("O gato mia.");
    }
}

class Principal {
    static void Main() {
        // Instância de Cachorro
        Animal meuCachorro = new Cachorro();
        meuCachorro.EmitirSom();  // Saída: "O cachorro late."

        // Instância de Gato
        Animal meuGato = new Gato();
        meuGato.EmitirSom();  // Saída: "O gato mia."

        // Instância de Animal
        Animal meuAnimal = new Animal();
        meuAnimal.EmitirSom();  // Saída: "O animal faz um som."
    }
}
