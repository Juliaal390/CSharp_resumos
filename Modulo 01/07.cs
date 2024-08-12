using System;

class Principal {
    
  static void Main() {
    //FORMAS DE DECLARAR ARRAYS
    int[] numeros = new int[5]; //array chamado numeros de tamanho 5 (0-4)
    char[] letras = new char[3]{'a','b','c'};
    int[] num = {2, 3, 7};
    
    //ATRIBUINDO VALOR A UM ELEMENTO DO ARRAY
    numeros[0] = 15;
    
    //FOREACH VS FOR
    foreach (int numero in numeros) { 
        Console.WriteLine(numero);
    }
    
    for(int i = 0; i < letras.Length; i++) {
        Console.WriteLine(letras[i]);
    }
    
    for(int i = 0; i < num.Length; i++) {
        Console.WriteLine(num[i]);
    }
  }
}
