namespace Aula40_08_02_2021
{
    public class TestaProduto
    {
        static void Main(string[] args)
        {
            Produto[] vetProduto = new Produto[2];

            System.Console.WriteLine("Dados dos Produtos: ");
            System.Console.WriteLine("********************");

            for (int i = 0; i < vetProduto.Length; i++)
            {
                vetProduto[i] = new Produto();

                System.Console.Write("Digite a Marca: ");
                vetProduto[i].Marca = System.Console.ReadLine();

                System.Console.Write("Digite a Modelo: ");
                vetProduto[i].Modelo = System.Console.ReadLine();

                System.Console.Write("Digite o Preço: ");
                vetProduto[i].Preco = System.Console.ReadLine();
            }

            foreach (Produto prod in vetProduto)
            {
                System.Console.WriteLine("\nMarca: " + prod.Marca + "\tModelo: " + prod.Modelo + "\tPreço: " + prod.Preco);
            }
        }
    }
}