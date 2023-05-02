using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            int day;

            //entrada(s)
            Console.Write("Informe um número de 1 a 7: ");
            day = Convert.ToInt32(Console.ReadLine());

            //processamento + saida
            switch (day)
            {
                case 1:
                    Console.Write("Segunda-feira");
                    break;
                case 2:
                    Console.Write("Terça-feira");
                    break;    
                case 3:
                    Console.Write("Quarta-feira");
                    break;
                case 4:
                    Console.Write("Quinta-feira");
                    break;
                case 5:
                    Console.Write("Sexta-feira");
                    break;
                case 6:
                    Console.Write("Sábado");
                    break;
                case 7:
                    Console.Write("Domingo");
                    break;      
                default:
                    Console.Write("Opção inválida!!!");
                    break; 
            }            

        }
    }
}
