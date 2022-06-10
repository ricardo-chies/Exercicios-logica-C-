using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex11
    {
        public //Exercício 11
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir se os números de 0 a 100 são primos:");
            Console.WriteLine("Aperte 'Enter' para continuar");
            Console.ReadKey();

            NumeroPrimo();
            Console.ReadKey();

        }

        public static void NumeroPrimo()
        {
            int n = 0;
            while (n <= 99)
            {
                n = n + 1;

                int divisores = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        divisores++;
                }
                if (divisores == 2)
                {
                    Console.WriteLine("{0} é um número primo", n);

                }
                else
                {
                    Console.WriteLine("{0} não é um número primo", n);

                }

            }
        }
    }
}