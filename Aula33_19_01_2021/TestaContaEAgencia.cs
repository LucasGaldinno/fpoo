namespace Aula35_19_01_2021
{
    public class TestaContaEAgencia
    {
        Agencia a = new Agencia();
        Conta c = new Conta();
        
        a.numero = 178;
        
        c.numero = 123;
        c.saldo = 1000.0;
        c.limite = 500;

        Console.WriteLine("Dados da agência "); 
        Console.WriteLine("Número : " + a.numero );

        Console.WriteLine("-------------------");

        Console.WriteLine("Dados da conta ");
        Console.WriteLine("Número : " + c.numero );
        Console.WriteLine("Saldo : " + c.saldo );
        Console.WriteLine("Limite : " + c.limite );

        Console.WriteLine("-------------------");

        c.agencia = a;

        Console.WriteLine("Dados do agência obtidos através da conta");
        Console.WriteLine(c.agencia.numero );
    }
}