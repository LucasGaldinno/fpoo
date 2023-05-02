using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variáveis
            float valor, taxa, tempo, prest;

            //entradas
            Console.Write("Digite o valor da dívida: ");
            valor = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a taxa de juros: ");
            taxa = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o tempo: ");
            tempo = Convert.ToSingle(Console.ReadLine());

            //processamento
            prest = valor + (valor * (taxa / 100) * tempo);

            //saida
            Console.Write("O valor da prestação é: R$" + prest.ToString("0.00"));
        }
    }
}
