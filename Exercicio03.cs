using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Exercicio03
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade:");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                if (idade < 0)
                {
                    Console.WriteLine("Idade inválida. A idade não pode ser negativa.");
                    return;
                }

                switch (idade)
                {
                    case <= 12:
                        Console.WriteLine("Criança");
                        break;
                    case <= 17:
                        Console.WriteLine("Adolescente");
                        break;
                    case <= 59:
                        Console.WriteLine("Adulto");
                        break;
                    default:
                        Console.WriteLine("Idoso");
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
