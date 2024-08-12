//SWITCH CASE
using System;

public enum DiaDaSemana {
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}

class Principal {
    static void Main() {
        DiaDaSemana hoje = DiaDaSemana.Quarta;
        string texto;

        switch (hoje) {
            case DiaDaSemana.Domingo:
                texto = "Hoje é domingo. Dia de descanso!";
                break;
            case DiaDaSemana.Segunda:
                texto = "Hoje é segunda-feira. Começo da semana.";
                break;
            case DiaDaSemana.Terca:
                texto = "Hoje é terça-feira. Continue firme!";
                break;
            case DiaDaSemana.Quarta:
                texto = "Hoje é quarta-feira. Meio da semana.";
                break;
            case DiaDaSemana.Quinta:
                texto = "Hoje é quinta-feira. Quase lá!";
                break;
            case DiaDaSemana.Sexta:
                texto = "Hoje é sexta-feira. Último dia útil!";
                break;
            case DiaDaSemana.Sabado:
                texto = "Hoje é sábado. Aproveite o fim de semana!";
                break;
            default:
                texto = "Dia inválido.";
                break;
        }

        Console.WriteLine(texto); // Exibe a mensagem armazenada em texto
    }
}
