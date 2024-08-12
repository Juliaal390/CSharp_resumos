//PROPRIEDADES STATIC
using System;

class ClasseCriada {
    // Propriedade estática
    public int TotalContadores=9;

    // Método estático
    public static void ExibirTexto() {
        Console.WriteLine("Método static acessado");
    }
}

class Programa {
    static void Main() {
        // Acessa o método estático diretamente através da classe
        ClasseCriada.ExibirTexto();
        
        /* O CÓDIGO ABAIXO DARÁ ERRO:
        
        Console.WriteLine(ClasseCriada.TotalContadores);
        
        POIS TOTALCONTADORES NÃO É STATIC PARA SER ACESSADO ASSIM, É NECESSÁRIO
        CRIAR UMA INSTÂNCIA DELE
        */
        
        ClasseCriada c1 = new ClasseCriada();
        Console.WriteLine(c1.TotalContadores);
    }
}
