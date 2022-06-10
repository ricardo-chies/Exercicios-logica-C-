using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex03
    {
        public static void Main(string[] args)
        {
            //Exercício 3

            Console.WriteLine("Vamos somar dois numeros");
            Console.WriteLine("Número 1");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Número 2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int resultado = Soma(n1, n2);

            Console.WriteLine("A soma {0} + {1} é igual a {2}", n1, n2, resultado);
            Console.ReadLine();

        }

        public static int Soma(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }
    }
}