namespace Arrays
{
    public class ExibeArgumentos
    {
        public void ExibirArgumentos(string[] nomes)
        {
            System.Array.Sort(nomes);
            foreach (string nome in nomes)
            {
                System.Console.WriteLine(nome);
            }
        }
    }
}