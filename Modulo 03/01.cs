/* TRY-CATCH-FINALLY: tratar exceções e garantir que certas ações ocorram, independe de erros.
try - Bloco de código que pode lançar uma exceção
catch - Bloco de código que lida com a exceção
finally -  Bloco de código que sempre será executado, independente se uma exceção ocorreu ou não
*/

using System;

class Programa {
    static void Main() {
        int n2 = 0;
        try {
            // Tenta realizar a operação
            int res = n2 / 0;
        }
        catch (DivideByZeroException) {
            // Trata especificamente a exceção de divisão por zero
            Console.WriteLine("Erro: Divisão por zero.");
        }
        catch (Exception ex) {
            // Trata qualquer outra exceção e exibe a mensagem da exceção
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}

//throw new exception("texto"): gera uma nova excessão personalizada