/*STRINGBUILDER: facilita a manipulação de strings de grande volume*/
using System;
using System.Text;
class HelloWorld {
  static void Main() {
    StringBuilder msg = new StringBuilder();

    msg.Append("Aprendendo StringBuilder. ");
    msg.Append("Otimize seu código C# ");

    string minhaMsg = msg.ToString();
    Console.Write(minhaMsg); //"Aprendendo StringBuilder. Otimize seu código C#"

    /*
    INSERT: insere texto em uma posição específica:
    msg.Insert(10, " sobre: "); >>>> "Aprendendo sobre: StringBuilder. Otimize seu código C#"

    remove, replace, clear
    */
  }
}