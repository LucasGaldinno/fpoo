using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            int num;

            //entrada
            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            //processamento
            if (num % 2 == 0) // % - mod
            {
                Console.Write("Este número é par");
            }
            else
            {
                Console.Write("Este número é ímpar");
            }            
        }
    }
}
