namespace Arrays
{
    public class TestaExibirArgumentos
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] {"Ana", "Erica", "Daniel"};

            ExibeArgumentos mandaExibir = new ExibeArgumentos();

            mandaExibir.ExibirArgumentos(nomes);
        }
    }
}