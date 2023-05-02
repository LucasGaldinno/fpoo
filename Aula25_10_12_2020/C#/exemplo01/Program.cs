using System;

namespace exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis - matriz
            int[,] matriz = new int[2,2];

            //Vamos montar a matriz 2x2 (quadrada)
            //loop com variavel i - controla o número de linhas
            for(int i = 0; i < 2; i++){

                //loop com variavel j - controle o número de colunas
                for(int j = 0; j < 2; j++){
                    Console.Write("Digite um elemento/valor: ");
                    matriz[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Vamos exibir a matriz 2x2 (quadrada)
            //loop com variavel i - controla o número de linhas
            for(int i = 0; i < 2; i++){

                //loop com variavel j - controle o número de colunas
                for(int j = 0; j < 2; j++){
                    Console.WriteLine("matriz[{0},{1}] = {2}", i, j, matriz[i,j]);                    
                }
            }
        }
    }
}
