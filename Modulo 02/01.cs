using System;

public class Jogador{
    public string nome = "André";
    public int pontos = 0;
}

class Principal {
    static void Main() {
        //objetos: instâncias de uma classe
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        
        j1.nome = "Lucas";
        j1.pontos = 50;
        
        Console.WriteLine(j1.nome + " - " + j1.pontos);
        Console.WriteLine(j2.nome + " - " + j2.pontos);
    }
}

