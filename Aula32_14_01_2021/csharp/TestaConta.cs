namespace csharp
{
    public class TestaConta
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.numero = 1;
            c1.saldo = 10;
            c1.limite = 100;

            Conta c2 = new Conta();
            c2.numero = 2;
            c2.saldo = 20;
            c2.limite = 200;

            System.Console.WriteLine("Dados da primeira conta");
            System.Console.WriteLine("Número: " + c1.numero);
            System.Console.WriteLine("Saldo: " + c1.saldo);
            System.Console.WriteLine("Limite: " + c1.limite);
            
            System.Console.WriteLine("Dados da segunda conta");
            System.Console.WriteLine("Número: " + c2.numero);
            System.Console.WriteLine("Saldo: " + c2.saldo);
            System.Console.WriteLine("Limite: " + c2.limite);
        }
    }
}