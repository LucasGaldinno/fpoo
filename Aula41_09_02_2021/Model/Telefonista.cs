namespace Aula41_09_02_2021
{
    public class Telefonista : Funcionario
    {
        public int EstacaoDeTrabalho { get; set; }

        public override void MostrarDados()
        {
            base.MostrarDados();
            System.Console.WriteLine("Estação de Trabalho: " + this.EstacaoDeTrabalho);
        }
    }
}