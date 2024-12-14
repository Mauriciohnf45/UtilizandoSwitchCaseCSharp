using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio09
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Digite a classificação etária do filme (G, PG, PG-13, R):");
            string classificacao = Console.ReadLine()?.ToUpper(); // Convertendo para maiúsculas para facilitar a comparação

            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Classificação: Livre para todas as idades.");
                    break;
                case "PG":
                    Console.WriteLine("Classificação: Permitido para maiores de 10 anos.");
                    break;
                case "PG-13":
                    Console.WriteLine("Classificação: Permitido para maiores de 13 anos.");
                    break;
                case "R":
                    Console.WriteLine("Classificação: Permitido apenas para maiores de 18 anos.");
                    break;
                default:
                    Console.WriteLine("Classificação inválida. Por favor, insira G, PG, PG-13 ou R.");
                    break;
            }
        }
    }
}

