using System;

using System.Globalization;

namespace CalculoComissaoVendedor2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
            * Um vendendor trabalha com frios. Para cada produto há uma aliquota de comissão,
            * conforme a especificação abaixo:
            * Mussarela:     5.0%   Preço kg: 22,60
            * Mortadela:     6.5%   Preço kg:  8,98
            * Presunto:      4.5%   Preço kg: 31,03
            * Peito de Peru: 2.5%   Preço kg: 58,90 
            * Sabendo da aliquota da comissão: faça um programa que leia as quantidades vendidas
            * pelo vendedor e calcule a comissão.
            */

            NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

            double salario_base = 0;

            Console.WriteLine("Informe o Salário o Base:");
            salario_base = Convert.ToDouble(Console.ReadLine());

            double qnt_vendida_mussarela = 0; // Kg
            double qnt_vendida_mortadela = 0;
            double qnt_vendida_presunto = 0;
            double qnt_vendida_peito_peru = 0;

            double valor_vendido_mussarela = 0; // R$
            double valor_vendido_mortadela = 0;
            double valor_vendido_presunto = 0;
            double valor_vendido_peito_peru = 0;

            double comissao_mussarela = 0; // R$ 
            double comissao_mortadela = 0;
            double comissao_presunto = 0;
            double comissao_peito_peru = 0;

            /**
             * Pedindo para o usuário digitar as quantidades vendidas.
             */ 
            Console.WriteLine("Qual a quantidade de mussarela vendida? Kg");
            qnt_vendida_mussarela = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de mortadela vendida? Kg");
            qnt_vendida_mortadela = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de presunto vendida? Kg");
            qnt_vendida_presunto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de peito de peru vendida? Kg");
            qnt_vendida_peito_peru = Convert.ToDouble(Console.ReadLine());

            /**
             * Calculando os valores vendidos.
             */
            valor_vendido_mussarela = qnt_vendida_mussarela * 22.6;
            valor_vendido_mortadela = qnt_vendida_mortadela * 8.98;
            valor_vendido_presunto = qnt_vendida_presunto * 31.03;
            valor_vendido_peito_peru = qnt_vendida_peito_peru * 58.90;

            /**
             * Calculando as comissões do vendedor
             */
            comissao_mussarela = valor_vendido_mussarela * 0.05;
            comissao_mortadela = valor_vendido_mortadela * 0.065;
            comissao_presunto = valor_vendido_presunto * 0.045;
            comissao_peito_peru = valor_vendido_peito_peru * 0.025;


            double total_comissao = comissao_mussarela + comissao_mortadela + comissao_presunto + comissao_peito_peru;

            // Limpando a tela "anterior"
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("VALORES CALCULADOS DA SUA COMISSÃO");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            /**
             * Apresentando os resultados.
             */ 
            Console.WriteLine(
                "Você vendeu {0} kg de Mussarela no valor de {1} sua comissão é {2}",
                qnt_vendida_mussarela.ToString("0.0"),
                valor_vendido_mussarela.ToString("C", nfi),
                comissao_mussarela.ToString("C", nfi)
             );

            Console.WriteLine(
                "Você vendeu {0} kg de Mortadela no valor de {1} sua comissão é {2}",
                qnt_vendida_mortadela.ToString("0.0"),
                valor_vendido_mortadela.ToString("C", nfi),
                comissao_mortadela.ToString("C", nfi)
             );

            Console.WriteLine(
                "Você vendeu {0} kg de Presunto no valor de {1} sua comissão é {2}",
                qnt_vendida_presunto.ToString("0.0"),
                valor_vendido_presunto.ToString("C", nfi),
                comissao_presunto.ToString("C", nfi)
             );

            Console.WriteLine(
                "Você vendeu {0} kg de Peito Peru no valor de {1} sua comissão é {2}",
                qnt_vendida_peito_peru.ToString("0.0"),
                valor_vendido_peito_peru.ToString("C", nfi),
                comissao_peito_peru.ToString("C", nfi)
             );

            Console.WriteLine("");

            Console.WriteLine("Sua Comissão Total é {0}", total_comissao.ToString("C", nfi));            


            double salario_total = salario_base + total_comissao;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Salário Total de {0}", salario_total.ToString("C", nfi));
            Console.BackgroundColor = ConsoleColor.Black;

            Console.CursorTop = 1;

            Console.ReadKey();
        }
    }
}
