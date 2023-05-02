namespace Aula40_08_02_2021
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string dtNascimento { get; set; }
        
        public void Comer(string tipo)
        {
            System.Console.WriteLine("A pessoa " + tipo + " comeu!!!");
        }
    }
}