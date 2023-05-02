namespace Aula41_09_02_2021
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalcularBonificacao()
        {
            return this.Salario * 0.1;
        }

        public virtual void MostrarDados()
        {
            System.Console.WriteLine("Nome:        " + this.Nome);
            System.Console.WriteLine("Salário:     " + this.Salario);
            System.Console.WriteLine("Bonificação: " + CalcularBonificacao());
        }
    }
}