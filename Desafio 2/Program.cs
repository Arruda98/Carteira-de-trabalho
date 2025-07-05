using System;
using System.ComponentModel.Design;
using System.Threading;

namespace Desafio
{
    class Salario
    {
        public static void Main(string[] args)
        {
            double hora = 0;
            double bruto = 0;
            double ir = 0.11;
            double inss = 0.8;
            double sindicato = 0.5;

            Console.WriteLine("Carteira de Trabalho");

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            Console.WriteLine("Me informe o valor da sua hora de trabalho: ");

            hora = double.Parse(Console.ReadLine());
            bruto = (hora * 8) * 22;

            double renda = bruto * ir;
            double ins  = bruto * inss;
            double trabalhador = bruto * sindicato;
            double total = renda + ins + trabalhador;

            Console.Clear();
            Console.WriteLine("Calculando...");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine($"Baseado na informação que você me passou, vou te passar o valor do seu salário já com os desconto: ");

            Thread.Sleep(1500);
            Console.WriteLine("Calculando...");
            Thread.Sleep(1500);

            Console.WriteLine($"Descontos: ");
            Console.WriteLine($"IR (11%): R$ {renda}");
            Console.WriteLine($"INSS (8%): R$ {ins}");
            Console.WriteLine($"SINDICATO (5%): R$ {trabalhador}");
            Console.WriteLine($"Valor total de descontos: R$ {total}");
        }
    }
}
