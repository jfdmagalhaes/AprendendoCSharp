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

            double salario = salario = 1200.70;

            //o int é um tipo de variavel que suporta valores ate 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //o short é um tipo de variavel de 64 bits
            long idade;
            idade = 13000000000000000;

            //o short é um tipo de variavel de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;

            float altura = 1.80f;


            Console.WriteLine("A execução acabou. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
