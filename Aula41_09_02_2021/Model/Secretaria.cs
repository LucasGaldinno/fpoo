namespace Aula41_09_02_2021
{
    public class Secretaria : Funcionario
    {
        public int Ramal { get; set; }

        public override void MostrarDados()
        {
            base.MostrarDados();
            System.Console.WriteLine("Ramal: " + this.Ramal);
        }
    }
}