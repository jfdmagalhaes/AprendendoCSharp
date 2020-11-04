using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ConversoesEOutrosTiposNumericos
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2");

            double salario;
            salario = 1200.70;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            int idade;
            idade = 16;

            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
