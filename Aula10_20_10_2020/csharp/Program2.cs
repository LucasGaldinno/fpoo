using System;

class MainClass {
  public static void Main (string[] args) {
    //declarar variáveis
    int a, b, aux;

    //entradas
    Console.Write("Digite o valor de A: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o valor de B: ");
    b = Convert.ToInt32(Console.ReadLine());

    //processamento
    aux = b;
    b = a;
    a = aux;

    //saida
    //Console.WriteLine("O valor de A é: " + a); //concatenação
    //Console.WriteLine("O valor de B é: " + b); //concatenação
    //Console.Write($"Valor de A = {a} \nValor de B = {b}"); //interpolação
    Console.Write($"A + B = {a+b}");
  }
}