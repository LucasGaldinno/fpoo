using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular o Fatorial de um número inteiro qualquer");
            
            Console.WriteLine("Digite um número inteiro qualquer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //declarar variáveis
            int contador = 1, fatorial = 1;

            //processamento
            while (contador <= num)
            {
                fatorial = fatorial * contador;
                contador = contador + 1;
            }
            Console.WriteLine($"O fatorial de {num} = {fatorial}");
        }
    }
}
