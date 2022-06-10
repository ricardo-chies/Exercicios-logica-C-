using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex12
    {
        public static void Main(string[] args)
        {
            //Exercício 12

            Console.WriteLine("Digite um número para descobrir o seu fatorial");
            int n = Convert.ToInt32(Console.ReadLine());

            int fatorialN = Fatorial(n);
            Console.WriteLine("O Fatorial de {0} é {1}", n, fatorialN);
            Console.ReadLine();
        }

        public static int Fatorial(int n)
        {
            int resultado = 1;
            while (n != 1)
            {
                resultado = resultado * n;
                n = n - 1;
            }
            return resultado;

        }
    }
}