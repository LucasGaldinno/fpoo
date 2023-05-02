using System;

namespace Aula07_06_10_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            float f;
            //float c;

            //entrada
            //Classe: Métodos, Propriedades, Eventos, etc
            //Classe Console
            //Métodos: Write e ReadLine
            Console.Write("Digite uma temperatura em graus Fahrenheit: ");
            f = Convert.ToSingle(Console.ReadLine());

            //processamento
            //c = (f - 32) * 5 / 9;

            //saida
            //Console.Write("A temperatura em graus Celcius é: " + c);
            //Console.Write(c);
            Console.Write("A temperatura em graus Celcius é: " + (f - 32) * 5 / 9);

        }
    }
}
