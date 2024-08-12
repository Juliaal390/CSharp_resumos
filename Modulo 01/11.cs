//STRUCTS
using System;

struct Ponto {
    public int X;
    public int Y;

    // Construtor para inicializar a estrutura
    public Ponto(int x, int y) {
        X = x;
        Y = y;
    }
}

class Programa {
    static void Main() {
        // Criando uma instância de Ponto
        Ponto ponto1 = new Ponto(10, 20);

        // Acessando e exibindo os valores dos campos diretamente
        Console.WriteLine($"Ponto 1 - X: {ponto1.X}, Y: {ponto1.Y}");

        // Modificando os campos diretamente
        ponto1.X = 30;
        ponto1.Y = 40;
        Console.WriteLine($"Ponto 1 Modificado - X: {ponto1.X}, Y: {ponto1.Y}");

        // Criando outra instância de Ponto
        Ponto ponto2 = new Ponto(5, 15);
        Console.WriteLine($"Ponto 2 - X: {ponto2.X}, Y: {ponto2.Y}");

        // Cópia da estrutura
        Ponto pontoCopia = ponto1;
        Console.WriteLine($"Ponto Copiado - X: {pontoCopia.X}, Y: {pontoCopia.Y}");
    }
}

