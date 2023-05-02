using System;

namespace ExercicioA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            //ler os elementos do array numeros
            Console.Write("Lendo os elementos do array numeros\n");
            for(int i = 0; i < numeros.Length; i++){
                Console.Write("Digite um número inteiro qualquer: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Exibindo com for() os elementos do array numeros
            Console.Write("\nExibindo os elementos do array numeros ...\n");
            for(int i = 0; i < numeros.Length; i++){
                Console.WriteLine(numeros[i]);
            }
            
            // "Console.Write("\nExibindo com foreach() os elementos do array numeros ...\n");
            // foreach(int num in numeros){
            //     Console.WriteLine(num);
            // }



        }
    }
}
