using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex19
    {
        public //Exercício 19
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            Console.WriteLine("Vamos descobrir a média aritmética dos números inteiros entre 15 e 100:");

            Tabuada();
            Console.ReadKey();

        }

        public static void Tabuada()
        {
            int soma = 0;
            for (int i = 15; i <= 100; i++)
            {
                soma = soma + i;

            }

            int media = soma / 87;
            Console.WriteLine("A soma dos números é {0} e sua média é {1}", soma, media);
        }
    }
}