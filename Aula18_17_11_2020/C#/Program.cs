using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variável
            int i;

            //estrutura de repetição FOR
            for(i = 15; i < 201; i++)
            {
                //Enquanto a condição for verdadeira
                Console.WriteLine($"O quadrado de {i} = {Math.Pow(i, 2)}"); //interpolação
                //Console.WriteLine("O quadrado de " + i + "é igual a " + Math.Pow(i, 2)); //concatenação
            }
        }
    }
}
