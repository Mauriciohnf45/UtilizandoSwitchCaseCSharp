using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma bebida pelo número:");
            Console.WriteLine("1 - Café");
            Console.WriteLine("2 - Chá");
            Console.WriteLine("3 - Suco");
            Console.WriteLine("4 - Refrigerante");
            Console.Write("Digite sua escolha: ");

            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Você escolheu: Café");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu: Chá");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu: Suco");
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu: Refrigerante");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha um número entre 1 e 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
            }
        }
    }
}

