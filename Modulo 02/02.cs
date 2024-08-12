/* CONSTRUTOR: chamado automaticamente quando se cria instância de uma classe, inicializa
propriedades. Toda classe possui, mesmo que não explicitamente. PRECISA ter o mesmo nome
da classe.

os construtores das classes base (superclasses) são executados antes dos construtores das classes derivadas (subclasses)
*/

using System;

public class Jogador{
    public string nome;
    public int pontos;
    
    //CONSTRUTOR
    public Jogador(){
        nome="André";
        pontos =0;
    }
    //é mais indicado inicializar as propriedades assim
    
    //CONSTRUTOR COM PARÂMETROS
    public int idade;
    public Jogador(int n){
        idade = n;
        
        nome="André";
        pontos =0;
    }
}

class Principal {
    static void Main() {
        //objetos: instâncias de uma classe
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador(22); //parâmetro passado para construtor
        
        j1.nome = "Lucas";
        j1.pontos = 50;
        
        Console.WriteLine(j1.nome + " - " + j1.pontos);
        Console.WriteLine(j2.nome + " - " + j2.pontos + " - " + j2.idade);
    }
}


