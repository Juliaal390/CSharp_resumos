//PROPRIEDADES
using System;

class Circulo {
    private double _raio;

    public double Raio {
        get {
            return _raio;
        }
        set {
            if (value < 0)
                throw new ArgumentException("O raio não pode ser negativo");
            _raio = value;
        }
    }

    public double Area {
        get {
            return Math.PI * _raio * _raio; 
        }
    }
}

class Principal {
    static void Main() {
        Circulo c = new Circulo();
        c.Raio = 5; // Define o raio
        Console.WriteLine(c.Area); // Calcula e exibe a área com base no raio
    }
}
