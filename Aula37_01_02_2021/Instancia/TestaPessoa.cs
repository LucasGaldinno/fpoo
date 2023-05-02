using System;

namespace Instancia
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos criar uma variável de instância da classe Pessoa
            Pessoa p = new Pessoa();

            p.nome = "José da Silva";
            p.idade = 20;
            p.rg = "12345678910";

            System.Console.WriteLine("Nome:  " + p.nome);
            System.Console.WriteLine("Idade: " + p.idade);
            System.Console.WriteLine("RG:    " + p.rg);
            p.Andar();
        }
    }
}
