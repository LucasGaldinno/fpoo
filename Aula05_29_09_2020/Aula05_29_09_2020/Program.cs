using System;

namespace Aula05_29_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variaveis
            // int num1;
            // int num2;
            // int soma;

            int num1, num2, soma;

            //1. Entrada(s)
            //Entrada do numero 1
            Console.Write("Digite o número 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Entrada do numero 2
            Console.Write("Digite o número 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //2. Processamento(s)
            soma = num1 + num2;

            //3. Saida(s)
            Console.Write("A soma é: " + soma);

            Console.ReadKey();
        }
    }
}
