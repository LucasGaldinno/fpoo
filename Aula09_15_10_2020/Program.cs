using System;

namespace Aula08_15_out_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            float tempo, vel_media, dist, litros_usados;

            //entrada
            Console.Write("Digite o tempo gasto na viagem: ");
            tempo = float.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade média gasta na viagem: ");
            vel_media = float.Parse(Console.ReadLine());

            //processamento
            dist = tempo * vel_media;
            litros_usados = dist / 12;

            //saida
            Console.WriteLine("A velocidade média é: " + Math.Round(vel_media, 2));
            Console.WriteLine("O tempo gasto na viagem é: " + Math.Round(tempo, 2));
            Console.WriteLine("A distância gasta na viagem é: " + Math.Round(dist, 2));
            Console.WriteLine("Os litros gastos na viagem são: " + Math.Round(litros_usados, 2));

        }
    }
}
