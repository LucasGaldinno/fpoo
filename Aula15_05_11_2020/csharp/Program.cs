// using System;

// namespace csharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //declarar variaveis
//             double novo_salario, salario;

//             //entrada(s)
//             Console.Write("Digite seu salário: ");
//             salario = Convert.ToSingle(Console.ReadLine());

//             //processamento + saida
//             if (salario < 500)
//             {
//                 novo_salario = salario * 1.15;
//             }
//             else if (salario <=1000 && salario >=500)
//             {
//                 novo_salario = salario * 1.10;
//             }
//             else
//             {
//                 novo_salario = salario * 1.05;
         
//             }

//             Console.WriteLine("Seu novo salário é: " + novo_salario.ToString("0.00")); //concatenação
//             Console.Write($"Seu novo salário é: {novo_salario.ToString("0.00")}");     //interpolação

//         }
//     }
// }
