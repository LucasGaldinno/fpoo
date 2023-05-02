namespace Construtores
{
    public class TestaProduto
    {
        static void Main(string[] args)
        {
            //prod1 com construtor padrão
            Produto prod1 = new Produto();

            prod1.nome = "HD SSD 240GB";
            prod1.preco = 350.00;
            prod1.quantidade = 100;

            System.Console.WriteLine("Dados do produto depois da instância");
            System.Console.WriteLine("Nome:       " + prod1.nome);
            System.Console.WriteLine("Preço:      " + prod1.preco);
            System.Console.WriteLine("Quantidade: " + prod1.quantidade);

            //prod2 com sobrecarga do construtor - nome
            Produto prod2 = new Produto("Mouse Wireless 1850dpi");
            System.Console.WriteLine("\nDados do produto somente com o nome");
            System.Console.WriteLine("Nome: " + prod2.nome);

            //prod3 com sobrecarga do construtor - nome e preco
            Produto prod3 = new Produto("Mouse Wireless 1850dpi", 70);
            System.Console.WriteLine("\nDados do produto com o nome e preco");
            System.Console.WriteLine("Nome : " + prod3.nome);
            System.Console.WriteLine("Preço: " + prod3.preco);

            //prod4 com sobrecarga do construtor - quantidade e preco
            Produto prod4 = new Produto(10, 70);
            System.Console.WriteLine("\nDados do produto com o quantidade e preco");
            System.Console.WriteLine("Quantidade: " + prod4.quantidade);
            System.Console.WriteLine("Preço     : " + prod4.preco);

            //prod5 com sobrecarga do construtor - quantidade e preco
            Produto prod5 = new Produto("Mouse Wireless 1850dpi", 10, 70);
            System.Console.WriteLine("\nDados do produto com o nome a quantidade e preco");
            System.Console.WriteLine("Nome      : " + prod5.nome);
            System.Console.WriteLine("Quantidade: " + prod5.quantidade);
            System.Console.WriteLine("Preço     : " + prod5.preco);

        }
    }
}