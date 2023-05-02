namespace Aula40_08_02_2021
{
    public class TestaAviao
    {
        static void Main(string[] args)
        {
            Aviao a1 = new Aviao();

            //atributos da classe base/pai: meiosTransporte
            a1.Marca = "Airbus";
            a1.Modelo = "A380";
            a1.anoFabricacao = 2020;
            a1.Combustivel = "Querosene de aviação";
            a1.numPassageiros = 868;

            //atributos da classe filho
            a1.Tipo = "Comercial";
            a1.Autonomia = 15;
            a1.horasVoo = 150000;

            System.Console.WriteLine("Marca: " + a1.Marca);
            System.Console.WriteLine("Modelo: " + a1.Modelo);
            System.Console.WriteLine("Ano de fabricação: " + a1.anoFabricacao);
            System.Console.WriteLine("Combustível: " + a1.Combustivel);
            System.Console.WriteLine("Número de passageiros: " + a1.numPassageiros);
            System.Console.WriteLine("Tipo do avião: " + a1.Tipo);
            System.Console.WriteLine("Autonomia de voô: " + a1.Autonomia);
            System.Console.WriteLine("Horas de voô: " + a1.horasVoo);
        }
    }
}