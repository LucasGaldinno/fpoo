namespace Aula40_08_02_2021
{
    public class TestaCarro
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro();

            //atributos da classe base/pai: meiosTransporte
            car1.Marca = "Chevrolet";
            car1.Modelo = "Camaro";
            car1.anoFabricacao = 2020;
            car1.Combustivel = "Gasolina";
            car1.numPassageiros = 2;

            //atributos da classe filho
            car1.Aro = 17;
            car1.Suspensao = "Esportiva";
            car1.Kilometragem = 0;

            System.Console.WriteLine("Marca:  " + car1.Marca);
            System.Console.WriteLine("Modelo: " + car1.Modelo);
            System.Console.WriteLine("Ano de fabricação: " + car1.anoFabricacao);
            System.Console.WriteLine("Combustível: " + car1.Combustivel);
            System.Console.WriteLine("Numero de passageiros: " + car1.numPassageiros);
            System.Console.WriteLine("Aro da roda: " + car1.Aro);
            System.Console.WriteLine("Suspensão: " + car1.Suspensao);
            System.Console.WriteLine("Kilometragem: " + car1.Kilometragem);

        }
    }
}