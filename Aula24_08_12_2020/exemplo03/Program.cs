using System;

namespace exemplo03
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] md = new float[8];
            float soma = 0;
            
            Console.WriteLine("Obtendo as médias dos alunos\n");
            for(int i = 0; i < md.Length; i++){
                Console.Write("Digite a nota do {0}º aluno: ", i + 1);
                md[i] = Convert.ToSingle(Console.ReadLine());
                soma = soma + md[i];
            }
            float mg = soma / md.Length;

            Console.Write("\n A média geral da turma é: " + mg);
        }
    }
}
