using System;

namespace Aula17_12_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            int a, b, c;

            //entradas
            Console.Write("Digite o valor do lado A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            c = Convert.ToInt32(Console.ReadLine());

            //processamento + saída
            if(a<b+c && b<a+c && c<a+b){
                if(a == b && b == c){
                    Console.Write("Triângulo Equilátero");
                }
                else if(a == b || a == c || c == b){
                    Console.Write("Triângulo Isósceles");
                }
                else{
                    Console.Write("Triângulo Escaleno");
                }
            }
            else{
                Console.Write("Não é triângulo");
            }
        }
    }
}
