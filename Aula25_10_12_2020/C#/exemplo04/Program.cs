using System;

namespace exemplo04
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz 4x4
            int[,] numeros = new int[4,4];
            for(int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write($"numero[{i},{j}] = ");
                    numeros[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Exibindo os elementos da diagonal principal");
            for(int i = 0; i < 4; i++){
                for(int j = 0; j < 4; j++){
                    if(i == j){
                        Console.WriteLine("numeros[{0},{1}] = {2}", i, j, numeros[i,j]);
                    }
                }
            }
            
        }
    }
}
