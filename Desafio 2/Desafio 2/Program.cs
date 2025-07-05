using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Threading;

namespace Desafio
{
    class Salario
    {
        public static void Main(string[] args)
        {
            //Instanciamento de variaveis
            double valorHora = 0;
            double horasTrabalhadas = 0;
            double dias = 0;
            double bruto = 0;
            double ir = 0.11;
            double inss = 0.8;
            double sindicato = 0.5;
            

            //Titulo
            Console.WriteLine("Carteira de Trabalho");
            Console.WriteLine("");

            //Solicita o valor da hora de trabalho e insere os dados na variavel "hora"
            Console.WriteLine("Me informe o valor da sua hora de trabalho: ");
            valorHora = double.Parse(Console.ReadLine());

            //Solicita os dias trabalhados e insere na variavel "dias"
            Console.WriteLine("Agora me informe quantas horas você trabalhou: ")
            dias = double.Parse(Console.ReadLine());

            //Solicita os dias trabalhados e insere na variavel "dias"
            Console.WriteLine("Agora me informe os dias trabalhados: ")
            dias = double.Parse(Console.ReadLine());

            bruto = (valorHora * horasTrabalhadas) * dias;

            double renda = bruto * ir;
            double ins  = bruto * inss;
            double trabalhador = bruto * sindicato;
            double total = renda + ins + trabalhador;
            double descontado = bruto - total;

            Console.Clear();
            Console.WriteLine("Calculando...");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Baseado na informação que você me passou, vou te passar o valor do seu salário já com os desconto: ");

            Thread.Sleep(1500);
            Console.WriteLine("Calculando...");
            Thread.Sleep(1500);

            Console.WriteLine($"Descontos: ");
            Console.WriteLine($"IR (11%): R$ {renda}");
            Console.WriteLine($"INSS (8%): R$ {ins}");
            Console.WriteLine($"SINDICATO (5%): R$ {trabalhador}");
            Console.WriteLine($"Valor total de descontos: R$ {total}");
            Console.WriteLine("");
            Console.WriteLine($"O valor bruto que você recebe é de R$ {bruto} e o valor com todos os descontos é de R$ {descontado}.")
        }
    }
}
