using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetorA = new double[4];
            double[] vetorB = new double[4];

            for(int i = 0; i < vetorA.Length; i++){
                Console.Write("Digite um valor para o vetorA: ");
                vetorA[i] = Convert.ToDouble(Console.ReadLine());

                vetorB[i] = Math.Pow(vetorA[i], 2);
                //vetorB[i] = vetorA[i] * vetorA[i];
            }

            for(int i = 0; i < vetorA.Length; i++){
                Console.WriteLine($"vetorA[{i}] = {vetorA[i]} \t vetorB[{i}] = {vetorB[i]}");
            }
               
        }
    }
}
