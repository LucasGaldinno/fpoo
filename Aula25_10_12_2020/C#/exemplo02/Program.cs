using System;

namespace exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz 3 x 2 do tipo string - nome de frutas
            //matriz 3 Linhas x 2 Colunas
            string[,] frutas = new string[3,2];

            //montar/ler os elementos da matriz frutas 3x2
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 2; j++){
                    Console.Write("Digite uma fruta: ");
                    frutas[i,j] = Console.ReadLine();
                }
            }

            //exibir os elementos da matriz frutas 3x2
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 2; j++){
                    Console.WriteLine("frutas[{0},{1}] = {2}", i, j, frutas[i,j]);          
                }
            }


        }
    }
}
