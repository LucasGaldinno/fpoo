namespace Estatico
{
    public class TestaConta
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            System.Console.WriteLine("Contador c1: " + c1.numero);

            Conta c2 = new Conta();
            System.Console.WriteLine("\nContador c2: " + c2.numero);

            System.Console.WriteLine("Contador: " + Conta.contador);
        }
    }
}