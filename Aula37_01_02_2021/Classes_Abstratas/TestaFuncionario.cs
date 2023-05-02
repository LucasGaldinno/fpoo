using System;

namespace Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            //atributos ou propriedades de instância - func
            func.nome = "José da Silva";
            func.salario = 2000;

            //atributo de classe - não necessita de instância - static
            Funcionario.valeRefeicaoDiario = 25;

            System.Console.WriteLine("Nome:                     " + func.nome);
            System.Console.WriteLine("Salário antes do aumento: " + func.salario);
            System.Console.WriteLine("Vale refeição antes do aumento: " + Funcionario.valeRefeicaoDiario);
            
            //Passando o valor do aumento do salário - 500
            func.AumentarSalario(500); //método de instância

            //Passando a taxa de aumento do valeRefeicaoDiario - método de classe - static
            Funcionario.ReajustarValeRefeicaoDiario(0.1);

            System.Console.WriteLine("\nNome:                     " + func.nome);
            System.Console.WriteLine("Vale refeição após o aumento:   " + Funcionario.valeRefeicaoDiario);
            System.Console.WriteLine("Salário após o aumento:         " + func.salario);

        }
    }
}
