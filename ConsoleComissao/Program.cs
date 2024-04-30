using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleComissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] vendas = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Insira o nome do vendedor: ");
                nome[i] = Console.ReadLine();

                Console.Write("Insira o total vendido: ");
                vendas[i] = double.Parse(Console.ReadLine());

                Console.Clear();
            }

            for (int j = 0; j < 5; j++)
            {
                if (vendas[j] <= 20000)
                {
                    vendas[j] = vendas[j] * 0.05;
                }
                else if (vendas[j] <= 40000)
                {
                    vendas[j] = vendas[j] * 0.06;
                }
                else if (vendas[j] > 40000)
                {
                    vendas[j] = vendas[j] * 0.07;
                }
                else
                {
                    Console.Write("Erro");
                }

                Console.Clear();
            }

            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("Nome: " + nome[k]);
                Console.WriteLine("Comissão: " + vendas[k]);
            }

            Console.ReadKey();
        }
    }
}
