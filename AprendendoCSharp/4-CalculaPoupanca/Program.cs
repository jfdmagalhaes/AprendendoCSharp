using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            { 
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá " + valorInvestido);
                contadorMes += 1;
            }
            Console.ReadLine();

        }
    }
}
