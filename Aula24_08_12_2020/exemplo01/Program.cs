using System;

namespace exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar array do tipo string com 4 elementos
            string[] carros = new string[4];

            //entrada + processamento
            for(int i = 0; i < carros.Length; i++){
                Console.Write("Digite o nome de um carro: ");
                carros[i] = Console.ReadLine();
            }

            //saida + processamento
            Console.WriteLine("Exibindo os carros com o loop for()\n");
            for(int i = 0; i < carros.Length; i++){
                //Console.WriteLine(carros[i]);
                //carros[0] = "Volvo"
                //carros[1] = "BMW"
                //carros[2] = "Ford"
                //carros[3] = "Mazda"
                Console.WriteLine("carros[{0}] = {1}", i, carros[i]);
            }

            Console.WriteLine("Exibindo os carros com o loop foreach()\n");
            foreach(string car in carros){
                Console.WriteLine(car);
            }
        }
    }
}
