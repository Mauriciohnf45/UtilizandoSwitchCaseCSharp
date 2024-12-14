using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio05
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota de 0 a 10:");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Nota inválida. Insira um valor entre 0 e 10.");
                    return;
                }

                switch (nota)
                {
                    case >= 9 and <= 10:
                        Console.WriteLine("Classificação: A");
                        break;
                    case >= 7 and < 9:
                        Console.WriteLine("Classificação: B");
                        break;
                    case >= 5 and < 7:
                        Console.WriteLine("Classificação: C");
                        break;
                    case >= 3 and < 5:
                        Console.WriteLine("Classificação: D");
                        break;
                    case >= 0 and < 3:
                        Console.WriteLine("Classificação: F");
                        break;
                    default:
                        Console.WriteLine("Erro inesperado.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }
        }
    }
}
