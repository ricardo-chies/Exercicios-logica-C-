using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex15
    {
        public //Exercício 15
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir qual o valor total da compra");

            Console.WriteLine("Digite qual fruta foi comprada");
            Console.WriteLine("Sendo 1 para Maçã e 2 para Morango:");
            float fruta = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos kg foram comprados:");
            float kg = float.Parse(Console.ReadLine());

            ValorCompra(kg, fruta);
            Console.ReadKey();

        }

        public static void ValorCompra(float kg, float fruta)
        {
            if (fruta == 1)
            {
                if (kg <= 5)
                {
                    double precoMaca = 1.80;
                    double custo = kg * precoMaca;
                    Console.WriteLine("Total a ser pago: R${0}", custo);
                }
                else if (kg <= 8)
                {
                    double precoMaca = 1.50;
                    double custo = kg * precoMaca;
                    Console.WriteLine("Total a ser pago: R${0}", custo);
                }
                else if (kg > 8)
                {
                    double precoMaca = 1.50;
                    double custo = kg * precoMaca;
                    double desconto = custo * 0.1;
                    double valorFinal = custo - desconto;
                    Console.WriteLine("Valor: {0} Desconto: {1} " +
                        "Total a ser pago: R${2}", custo, desconto, valorFinal);
                }
            }

            if (fruta == 2)
            {
                if (kg <= 5)
                {
                    double precoMorango = 2.50;
                    double custo = kg * precoMorango;
                    Console.WriteLine("Total a ser pago: R${0}", custo);
                }
                else if (kg <= 8)
                {
                    double precoMorango = 2.20;
                    double custo = kg * precoMorango;
                    Console.WriteLine("Total a ser pago: R${0}", custo);
                }
                else if (kg > 8)
                {
                    double precoMorango = 2.20;
                    double custo = kg * precoMorango;
                    double desconto = custo * 0.1;
                    double valorFinal = custo - desconto;
                    Console.WriteLine("Valor: {0} Desconto: {1} " +
                        "Total a ser pago: R${2}", custo, desconto, valorFinal);
                }
            }

        }
    }
}