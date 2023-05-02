using System;

namespace ExercicioB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[4];
            int[] vetorB = new int[4];

            //lendo os elementos do vetorA e construindo o vetorB
            Console.WriteLine("Lendo os elementos do vetorA e construindo o vetorB");
            for(int i = 0; i < vetorA.Length; i++){
                Console.Write("Digite um elemento para o vetorA: ");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
                vetorB[i] = vetorA[i] * 3;
            }

            for(int i = 0; i < vetorA.Length; i++){
                Console.WriteLine($"vetorA[{i}] = {vetorA[i]} \t vetorB[{i}] = {vetorB[i]}");
            }
            //   \n = new line ou quebra de linha
            //   \t = tabulação
        }
    }
}
