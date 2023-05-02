using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.Write("Você é maior de idade...");
            }
            else
            {
                Console.Write("Você é menor de idade...");
                
            }
        }
    }
}
