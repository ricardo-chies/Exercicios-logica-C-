using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex13
    {
        public //Exercício 13
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir qual foi o valor do abastecimento");
            Console.WriteLine("Digite o valor de litros abastecidos");
            float litros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o tipo de combustível abastecido");
            Console.WriteLine("Sendo 'A' para Álcool e 'G' para Gasolina");
            string combus = Console.ReadLine();

            ValorAbastecimento(litros, combus);
            Console.ReadKey();

        }

        public static void ValorAbastecimento(float litros, string combus)
        {
            if (combus == "A")
            {
                double precoA = 2.90;

                if (litros <= 20)
                {
                    double custo = litros * precoA;
                    double desconto = custo * 0.03;
                    double valorFinal = custo - desconto;
                    Console.WriteLine("Valor: {0} Desconto: {1} " +
                        "Total a ser pago: {2}", custo, desconto, valorFinal);
                }
                else if (litros > 20)
                {
                    double custo = litros * precoA;
                    double desconto = custo * 0.05;
                    double valorFinal = custo - desconto;
                    Console.WriteLine("Valor: {0} Desconto: {1} " +
                        "Total a ser pago: {2}", custo, desconto, valorFinal);
                }
            }

            if (combus == "G")
            {
                double precoG = 3.30;

                if (litros <= 20)
                {
                    double custo = litros * precoG;
                    double desconto = custo * 0.04;
                    double valorFinal = custo - desconto;
                    Console.WriteLine("Valor: {0} Desconto: {1} " +
                        "Total a ser pago: {2}", custo, desconto, valorFinal);
                }
                else if (litros > 20)
                {
                    double custo = litros * precoG;
                    double desconto = custo * 0.06;
                    double valorFinal = custo - desconto;
                    Console.WriteLine("Valor: {0} Desconto: {1} " +
                        "Total a ser pago: {2}", custo, desconto, valorFinal);
                }

            }
        }
    }
}