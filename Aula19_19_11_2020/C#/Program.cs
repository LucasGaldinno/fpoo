using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentar os quadrados dos números inteiros de 15 a 200.
            int i = 15; //valor inicial
            while (i <= 200) //valor final
            {
                //Console.WriteLine($"O quadrado de {i} = {Math.Pow(i, 2)}"); //interpolação
                Console.WriteLine("O quadrado de " + i + " = " + Math.Pow(i, 2)); //concatenação
                i++; //passo
            }
        }
    }
}
