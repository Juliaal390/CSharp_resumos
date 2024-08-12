/*
DESTRUTORES:  liberar recursos antes que um objeto seja removido da memória pelo garbage
collector (coletor de lixo). O GB já faz isso automaticamente, então não é muito usado,
mas por precaução, pode-se usar ao lidar com Arquivos, Conexões e Recursos de Sistemas
Operacionais. Para tanto pode-se acrescentar em suas classes a interface IDisposable e
usar um bloco using para garantir que ao fim do processo, o método Dispose() seja chamado,
e colocar no destrutor código especial para liberar recursos, sejam de conexão, arquivo
aberto, acesso a banco de dados etc.

- Não possui modificadores de acesso, nem parâmetros, nem retorno
- Não podem ser herdados, e cada classe deve ter no máximo 1

*/

using System;

class Recurso {
    // Construtor
    public Recurso() {
        Console.WriteLine("Recurso alocado.");
    }

    // Destrutor
    ~Recurso() {
        Console.WriteLine("Recurso liberado.");
    }
}

class Principal {
    static void Main() {
        Recurso r = new Recurso();
    }
}


