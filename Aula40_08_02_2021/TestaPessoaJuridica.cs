namespace Aula40_08_02_2021
{
    public class TestaPessoaJuridica
    {
        static void Main(string[] args)
        {
            Juridica j1 = new Juridica();

            j1.Nome = "Antero de Oliveira";
            j1.dtNascimento = "01/02/2000";
            j1.CNPJ = "12345678-90";

            System.Console.WriteLine("Dados Pessoa Jurídica");
            System.Console.WriteLine("*********************");
            System.Console.WriteLine("Nome:               " + j1.Nome);
            System.Console.WriteLine("Data de Nascimento: " + j1.dtNascimento);
            System.Console.WriteLine("CNPJ:               " + j1.CNPJ);
            j1.Comer("Jurídica");

        }
    }
}