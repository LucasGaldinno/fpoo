using System;

namespace exemplo03
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz 2 x 4 de carros
            //montar/ler os elementos da matriz com a estrutura de repetição for()
            string[,] carros = new string[2,4];

            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 4; j++){
                    Console.Write("Digite o nome de um carro: ");
                    carros[i,j] = Console.ReadLine();
                }
            }

            //exibir a matriz com a estrutura de repetição foreach()
            foreach(string car in carros){
                Console.WriteLine(car);
            }


        }
    }
}
