using System;

namespace Aula07_06_10_2020
{
    public class volume
    {
        static void Main(string[] args)
        {

        //declarar variaveis
        Double raio, altura, vol;

        //entrada(s)
        Console.WriteLine("Calculadora de volume de lata: ");
        Console.WriteLine("-------------------------------");
       
        Console.Write("Digite o valor do raio: ");
        raio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor da altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        //processamento
        vol = 3.1415 * Math.Pow(raio, 2) * altura;

        //saida(s)
        Console.Write("O volume da lata é: " + vol);


        }
    }
}