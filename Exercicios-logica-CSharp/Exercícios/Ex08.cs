using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex08
    {
        public static void Main(string[] args)
        {
            //Exercício 8

            Console.WriteLine("Aperte 'Enter' para imprimir os números de 0 à 100");
            Console.ReadLine();

            Numeros0a100();
            Console.ReadLine();
        }

        public static void Numeros0a100()
        {
            int n = 0;
            while (n <=
                100)
            {
                Console.WriteLine(n);
                n = n + 1;
            }

        }
    }
}