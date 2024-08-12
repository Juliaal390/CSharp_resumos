//ABSTRAÇÃO
using System;

// Classe abstrata
abstract class Animal {
    // Método concreto na classe abstrata
    public void Respirar() {
        Console.WriteLine("O animal está respirando.");
    }

    // Método abstrato
    public abstract void EmitirSom();
}

class Cachorro : Animal {
    // Implementação do método abstrato OBRIGATÓRIO
    public override void EmitirSom() {
        Console.WriteLine("O cachorro late.");
    }
}

class Gato : Animal {
    // Implementação do método abstrato OBRIGATÓRIO
    public override void EmitirSom() {
        Console.WriteLine("O gato mia.");
    }
}

class Principal {
    static void Main() {
        // Não podemos instanciar a classe abstrata diretamente, mas podemos instanciar classes derivadas de Animal
        Cachorro meuCachorro = new Cachorro();
        Gato meuGato = new Gato();

        meuCachorro.Respirar();  // Saída: "O animal está respirando."
        meuCachorro.EmitirSom(); // Saída: "O cachorro late."

        meuGato.Respirar();  // Saída: "O animal está respirando."
        meuGato.EmitirSom(); // Saída: "O gato mia."
    }
}
