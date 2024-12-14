using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            if (double.TryParse(Console.ReadLine(), out double numero1))
            {
                Console.WriteLine("Digite o segundo número:");
                if (double.TryParse(Console.ReadLine(), out double numero2))
                {
                    Console.WriteLine("Digite o operador (+, -, *, /):");
                    string operador = Console.ReadLine();

                    switch (operador)
                    {
                        case "+":
                            Console.WriteLine($"Resultado: {numero1 + numero2}");
                            break;
                        case "-":
                            Console.WriteLine($"Resultado: {numero1 - numero2}");
                            break;
                        case "*":
                            Console.WriteLine($"Resultado: {numero1 * numero2}");
                            break;
                        case "/":
                            if (numero2 != 0)
                                Console.WriteLine($"Resultado: {numero1 / numero2}");
                            else
                                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                            break;
                        default:
                            Console.WriteLine("Operador inválido. Por favor, use +, -, * ou /.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. O segundo número deve ser um valor numérico.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. O primeiro número deve ser um valor numérico.");
            }
        }
    }
}
