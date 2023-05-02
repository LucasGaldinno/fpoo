using System;

namespace exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            for(int i = 0; i < numeros.Length; i++){
                Console.Write("Digite um número inteiro qualquer: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nExibindo os elementos com for\n");
            for(int i = 0; i < numeros.Length; i++){
                Console.WriteLine("numeros[{0}] = {1}", i, numeros[i]);
            }

            Console.WriteLine("\nExibindo os elementos com foreach\n");
            foreach(int num in numeros){
                Console.WriteLine(num);
            }
            
        }
    }
}
