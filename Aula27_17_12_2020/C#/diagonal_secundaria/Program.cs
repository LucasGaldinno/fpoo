using System;

namespace diagonal_secundaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];

            //criar a linha
            for(int i = 0; i < 3; i++){
                //criar a coluna
                for(int j = 0; j < 3; j++){
                    Console.Write("Digite um valor para a matriz[{0},{1}]: ", i, j);
                    matriz[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    if((i+j) == 2){
                        Console.WriteLine($"matriz[{i},{j}] = {matriz[i,j]}");
                    }
                }
            }
        }
    }
}
