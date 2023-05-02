namespace Estatico
{
    public class Conta
    {
        public static int contador { get; set; }

        public int numero { get; set; }

        public Conta()
        {
            Conta.contador++;
            this.numero = Conta.contador;
        }
    }
}