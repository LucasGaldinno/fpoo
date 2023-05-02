namespace Classes_Abstratas
{
    public class Funcionario
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public static double valeRefeicaoDiario { get; set; }

        //método de instância
        public void AumentarSalario(double aumento)
        {
            this.salario += aumento;
        }

        //método de classe - não necessita de instância
        public static void ReajustarValeRefeicaoDiario(double taxa){
            Funcionario.valeRefeicaoDiario += Funcionario.valeRefeicaoDiario * taxa;
        }
    }
}