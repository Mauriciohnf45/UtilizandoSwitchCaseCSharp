using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio07
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário (R$):");

            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                if (salario < 0)
                {
                    Console.WriteLine("O salário não pode ser negativo. Por favor, insira um valor válido.");
                    return;
                }

                double imposto;

                switch (salario)
                {
                    case <= 1500:
                        imposto = salario * 0.05;
                        Console.WriteLine($"Faixa: Até R$1.500,00\nImposto: R${imposto:F2}");
                        break;
                    case <= 3000:
                        imposto = salario * 0.10;
                        Console.WriteLine($"Faixa: De R$1.501,00 a R$3.000,00\nImposto: R${imposto:F2}");
                        break;
                    default:
                        imposto = salario * 0.15;
                        Console.WriteLine($"Faixa: Acima de R$3.000,00\nImposto: R${imposto:F2}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            }
        }
    }
}
