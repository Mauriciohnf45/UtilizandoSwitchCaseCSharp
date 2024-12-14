using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio08
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Escolha o tipo de conversão:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.Write("Digite sua escolha: ");

            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                switch (escolha)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        if (double.TryParse(Console.ReadLine(), out double celsius))
                        {
                            double fahrenheit = (celsius * 9 / 5) + 32;
                            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2} °F");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                        }
                        break;

                    case 2:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        if (double.TryParse(Console.ReadLine(), out double fahrenheitInput))
                        {
                            double celsiusConverted = (fahrenheitInput - 32) * 5 / 9;
                            Console.WriteLine($"Temperatura em Celsius: {celsiusConverted:F2} °C");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Escolha 1 ou 2.");
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

