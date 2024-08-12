/*
STATIC: não permite o uso de construtores.
Todos os seus membros devem ser static.
Não precisam ser instanciaadas.
Útil quando há métodos e vars/constantes utilitários (ex.: função de somar, constantes, etc)
*/

using System;

static class Jogador {
    static string nome;
    static int pontos;
    
    public static void Iniciar(string n) {
        nome = n;
        pontos = 0; // Inicializa os pontos
    }

    public static void ExibirInfo() {
        Console.WriteLine(nome + " - " + pontos);
    }
}

class Principal {
    static void Main() {
        Jogador.Iniciar("André");
        Jogador.ExibirInfo();
    }
}



