using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variavel
            int total = 0;
            
            //processsamento + saída
            for (int i = 1; i <= 1000; i++)
            {
                total = total + i;
                //total += i;
            }
            Console.Write("O total da soma dos números entre 1 e 1000 é: " + total);//concatenação

            Console.Write("\n\nFim do programa!!!");
           
        }
    }
}
