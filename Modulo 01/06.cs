//GOTO: permite que você salte para uma parte específica do código, marcada com um rótulo. Evite usá-lo.
using System;

class Principal {
    static void Main() {
        int i = 0;

        while (true) {
            while (true) {
                if (i == 5) {
                    goto FimDoLoop; // Alternativa: usar 'break' ou 'return'
                }
                i++;
            }
        }

        FimDoLoop:
        Console.WriteLine("Loop terminado.");
    }
}
