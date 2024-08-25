/* INTERFACES: descrevem características de propriedades, mas deixam a implementação para estruturas ou classes. Normalmente ficam em arquivos separados como módulos/classes. EX.: IAbastecimentoService.cs.
OBS.: Classes que implementam interfaces são obrigadas a implementar todos os métodos presentes.
*/
using System;

// Declaração da interface
interface IAnimal {
    void Comer();
    void Dormir();
    string Nome { get; set; }
}

// Implementação da interface
class Cachorro : IAnimal {
    public string Nome { get; set; }

    public void Comer() {
        Console.WriteLine($"{Nome} está comendo.");
    }

    public void Dormir() {
        Console.WriteLine($"{Nome} está dormindo.");
    }
}

class Principal {
    static void Main() {
        IAnimal meuCachorro = new Cachorro { Nome = "Rex" };
        meuCachorro.Comer();
        meuCachorro.Dormir();
        Console.WriteLine($"Nome do cachorro: {meuCachorro.Nome}");
    }
}
/*
OBS.: a classe cachorro não pode ter métodos que não estão definidos na interface, foi foi instanciada como tipo IAnimal. Se trocar a linha por Cachorro meuCachorro = new Cachorro { Nome = "Rex" }; não ocasionará erro
*/
