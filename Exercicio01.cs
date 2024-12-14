using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 7 para saber o dia da semana:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Segunda-feira");
                        break;
                    case 3:
                        Console.WriteLine("Terça-feira");
                        break;
                    case 4:
                        Console.WriteLine("Quarta-feira");
                        break;
                    case 5:
                        Console.WriteLine("Quinta-feira");
                        break;
                    case 6:
                        Console.WriteLine("Sexta-feira");
                        break;
                    case 7:
                        Console.WriteLine("Sábado");
                        break;
                    default:
                        Console.WriteLine("Número inválido. Digite um número entre 1 e 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }
    }
}
