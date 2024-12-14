using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro para calcular o fatorial:");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                switch (numero)
                {
                    case < 0:
                        Console.WriteLine("Erro: Não é possível calcular o fatorial de um número negativo.");
                        break;

                    case 0:
                        Console.WriteLine("O fatorial de 0 é 1.");
                        break;

                    default:
                        long fatorial = 1;
                        for (int i = 1; i <= numero; i++)
                        {
                            fatorial *= i;
                        }
                        Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
        }
    }
}
