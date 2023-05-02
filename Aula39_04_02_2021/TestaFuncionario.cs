namespace Aula39_04_02_2021
{
    public class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            f.Nome = "Rafael Cosentino";
            f.Salario = 2000;

            System.Console.WriteLine("Nome:    " + f.Nome);
            System.Console.WriteLine("Salário: " + f.Salario);
        }
    }
}