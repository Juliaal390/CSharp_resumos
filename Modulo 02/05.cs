//HERANÇA
using System;

class Animal {
    public string tipo;
    public string porte;
    private int idade; 
}

class Cachorro : Animal { 
    public Cachorro() { //construtor
        tipo = "Cachorro";
        porte = "Médio";
    }
    
    //idade não pode ser acessado nem instanciado
}

class Principal {
    static void Main() {
        Animal a1 = new Animal();
        Console.WriteLine("Tipo: " + a1.tipo);
        Console.WriteLine("Porte: " + a1.porte);
        
        Cachorro c1 = new Cachorro();
        Console.WriteLine("Tipo: " + c1.tipo);
        Console.WriteLine("Porte: " + c1.porte);
    }
}
