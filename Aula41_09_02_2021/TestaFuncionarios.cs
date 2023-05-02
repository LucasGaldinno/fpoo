namespace Aula41_09_02_2021
{
    public class TestaFuncionarios
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Rafael Cosentino";
            g.Salario = 2000;
            g.Usuario = "rafael cosentino";
            g.Senha = "12345";

            Telefonista f = new Telefonista();
            f.Nome = "Carolina Mello";
            f.Salario = 1000;
            f.EstacaoDeTrabalho = 13;

            Secretaria s = new Secretaria();
            s.Nome = "Tatiane Andrade";
            s.Salario = 1500;
            s.Ramal = 198;

            System.Console.WriteLine("GERENTE");
            // System.Console.WriteLine("Nome:    " + g.Nome);
            // System.Console.WriteLine("Salário: " + g.Salario);
            // System.Console.WriteLine("Usuário: " + g.Usuario);
            // System.Console.WriteLine("Senha:   " + g.Senha);
            g.MostrarDados();
            //System.Console.WriteLine("Bonificação: " + g.CalcularBonificacao());

            System.Console.WriteLine("\nTELEFONISTA");
            // System.Console.WriteLine("Nome:                " + f.Nome);
            // System.Console.WriteLine("Salário:             " + f.Salario);
            // System.Console.WriteLine("Estação de Trabalho: " + f.EstacaoDeTrabalho);
            f.MostrarDados();
            //System.Console.WriteLine("Bonificação: " + f.CalcularBonificacao());

            System.Console.WriteLine("\nSECRETARIA");
            // System.Console.WriteLine("Nome:    " + s.Nome);
            // System.Console.WriteLine("Salário: " + s.Salario);
            // System.Console.WriteLine("Ramal:   " + s.Ramal);
            s.MostrarDados();
            //System.Console.WriteLine("Bonificação: " + s.CalcularBonificacao());
            


        }
    }
}