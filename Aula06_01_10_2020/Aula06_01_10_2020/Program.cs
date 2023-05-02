using System;

namespace Aula06_01_10_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            float c;
            float f;

            //entrada(s)
            Console.Write("Digite a temperatura da sua cidade: ");
            c = Convert.ToSingle(Console.ReadLine());

            //processamento
            f = (9 * c + 160) / 5;

            //saída(s)
            Console.Write("Esta temperatura em Fahrenheit é: " + f);
        }
    }
}
