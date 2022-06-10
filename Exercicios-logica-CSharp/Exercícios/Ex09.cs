using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex09
    {
        public static void Main(string[] args)
        {
            //Exercício 9

            Console.WriteLine("Aperte 'Enter' para imprimir os números de 0 à 100 e se eles são pares ou ímpares");
            Console.ReadLine();

            Numeros0a100();
            Console.ReadLine();
        }

        public static void Numeros0a100()
        {
            int n = 0;
            while (n <=
                99)
            {
                n = n + 1;
                if (n % 2 == 1)
                {
                    Console.WriteLine("{0} é impar", n);
                }
                else
                {
                    Console.WriteLine("{0} é par", n);
                }
            }

        }
    }
}