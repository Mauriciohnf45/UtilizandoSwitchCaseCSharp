using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio04
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu de Opções:");
                Console.WriteLine("1 - Exibir \"Olá, Mundo!\"");
                Console.WriteLine("2 - Exibir \"Bem-vindo ao C#\"");
                Console.WriteLine("3 - Sair do programa");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("\nOlá, Mundo!");
                            break;
                        case 2:
                            Console.WriteLine("\nBem-vindo ao C#");
                            break;
                        case 3:
                            Console.WriteLine("\nSaindo do programa...");
                            return; // Encerra o programa
                        default:
                            Console.WriteLine("\nOpção inválida. Escolha uma opção entre 1 e 3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, digite um número.");
                }
            }
        }
    }
}
