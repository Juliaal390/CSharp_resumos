using System; //entrada e saída

class Principal{
    static void Main(){
        string nome;
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        
        Console.WriteLine("Seu nome é " + nome);
        Console.WriteLine("Seu nome é {0}", nome);
        Console.WriteLine($"Seu nome é {nome}");
    }
}
