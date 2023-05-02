namespace Aula41_09_02_2021
{
    public class Gerente : Funcionario
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public override double CalcularBonificacao()
        {
            return this.Salario * 0.6 + 100;
        }

        public override void MostrarDados()
        {
            base.MostrarDados();
            System.Console.WriteLine("Usuário: " + this.Usuario);
            System.Console.WriteLine("Senha:   " + this.Senha);
        }
    }
}